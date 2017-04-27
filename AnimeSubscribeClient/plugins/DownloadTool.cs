using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSubscribeClient.plugins
{
    public abstract class DownloadTool
    {
        protected string Host { get; set; }
        protected int Port { get; set; }
        protected string User { get; set; }
        protected string Pass { get; set; }

        protected readonly HttpClient _httpClient;
        protected readonly HttpClientHandler _httpClientHandler;

        public DownloadTool(string host, int port, string user, string pass)
        {
            this.Host = host;
            this.Port = port;
            this.User = user;
            this.Pass = pass;

            _httpClientHandler = new HttpClientHandler();
            _httpClient = new HttpClient(_httpClientHandler) { BaseAddress = new Uri(String.Format("http://{0}:{1}", this.Host, this.Port)) };
        }

        protected abstract bool IsAuthenticated();

        protected abstract Task<bool> Login();

        protected async Task CheckAuthentification()
        {
            if (!IsAuthenticated())
            {
                if (!await Login())
                {
                    throw new SecurityException();
                }
            }
        }

        public abstract Task<bool> AddMagnet(string magnet, string path, string label = null);

        public abstract Task<bool> AddTorrentByUrl(string torrentUrl, string path, string label = null);
    }
}