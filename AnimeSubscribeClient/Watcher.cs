using AnimeSubscribeClient.model;
using AnimeSubscribeClient.plugins;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimeSubscribeClient
{
    public class Watcher
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;

        private readonly Thread _thread;
        private ManualResetEvent _mre;

        private DownloadTool _tool;
        private string _path;
        private Form1 _form;

        public string Host { get; set; }
        public string Token { get; set; }

        public int DefaultLoopTime = 60 * 60 * 1000;
        public int LoopTime = 60 * 60 * 1000;

        public bool IsRunuing = false;

        public Watcher(string host, string token, string path, DownloadTool tool, Form1 form)
        {
            this.Host = host;
            this.Token = token;
            this._tool = tool;
            this._path = path;
            this._form = form;

            _httpClientHandler = new HttpClientHandler();
            try
            {
                _httpClient = new HttpClient(_httpClientHandler) { BaseAddress = new Uri(this.Host.StartsWith("http") ? this.Host : String.Format("http://{0}", this.Host)) };
            }
            catch (Exception)
            {
                throw;
            }

            _thread = new Thread(CheckThread);
            _mre = new ManualResetEvent(false);
        }

        private async Task<List<Episode>> FetchEpisodes()
        {
            var stringBuilder = new StringBuilder();

            var uriDownload = new Uri(String.Format("episodes/{0}", this.Token), UriKind.Relative);

            try
            {
                var jsonStr = await _httpClient.GetStringAsync(uriDownload);

                var jsonObj = JsonConvert.DeserializeObject<EpisodesResult>(jsonStr);

                if (jsonObj.Status)
                {
                    return jsonObj.Episodes;
                }

                return new List<Episode>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<bool> DeleteEpisode(string id)
        {
            var stringBuilder = new StringBuilder();

            var uriDownload = new Uri(String.Format("episode/{0}", id), UriKind.Relative);
            try
            {
                var res = await _httpClient.DeleteAsync(uriDownload);
                var jsonStr = await res.Content.ReadAsStringAsync();

                var jsonObj = JsonConvert.DeserializeObject<EpisodesResult>(jsonStr);

                return jsonObj.Status;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<int> LastUpdateTime()
        {
            var stringBuilder = new StringBuilder();

            var uriDownload = new Uri(String.Format("lastupdate"), UriKind.Relative);
            try
            {
                var res = await _httpClient.GetAsync(uriDownload);
                var jsonStr = await res.Content.ReadAsStringAsync();

                var jsonObj = JsonConvert.DeserializeObject<LastUpdate>(jsonStr);

                if (jsonObj.Status)
                {
                    DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
                    return (int)((DateTime.Now - startTime).TotalMilliseconds - jsonObj.LastUpdateTime);
                }

                return DefaultLoopTime;
            }
            catch (Exception)
            {
                return DefaultLoopTime;
            }
        }

        private async void CheckThread()
        {
            while (IsRunuing)
            {
                try
                {
                    var episodes = await FetchEpisodes();
                    Logger.Info(String.Format("发现{0}个新动画", episodes.Count));

                    foreach (var episode in episodes)
                    {
                        Logger.Info(episode.Title);
                        var res = await _tool.AddTorrentByUrl(episode.Torrent, Path.Combine(_path, episode.Name), episode.Name);
                        if (res)
                        {
                            var a = await DeleteEpisode(episode.ID);
                        }
                        else
                        {
                            Logger.Info("添加下载失败");
                        }
                    }
                    LoopTime = Math.Abs(DefaultLoopTime - await LastUpdateTime() + 5 * 60 * 1000);
                    Logger.Info(string.Format("下次更新时间是：{0}", DateTime.Now.AddMilliseconds(LoopTime)));
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    if (LoopTime == DefaultLoopTime)
                    {
                        LoopTime = 10 * 1000;
                    }
                    else
                    {
                        LoopTime *= 2;
                    }
                    this._form.ShowNotification(System.Windows.Forms.ToolTipIcon.Error, " 新番订阅", string.Format("发生错误，{0}秒后重试", LoopTime / 1000));
                }
                _mre.WaitOne(Math.Min(LoopTime, DefaultLoopTime));
            }
        }

        public void Start()
        {
            IsRunuing = true;
            try
            {
                _thread.Start();
            }
            catch (Exception)
            {
                throw;
            }
            Logger.Info("任务开始...");
        }

        public void Stop()
        {
            IsRunuing = false;
            _mre.Set();
            Logger.Info("任务结束...");
        }
    }
}