﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security;
using System.Net.Http.Headers;

namespace AnimeSubscribeClient.plugins
{
    public class QBittorrent : DownloadTool
    {
        public QBittorrent(string host, int port, string user, string pass) : base(host, port, user, pass)
        {
        }

        protected override async Task<bool> Login()
        {
            HttpContent bodyContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", this.User),
                new KeyValuePair<string, string>("password", this.Pass)
            });

            var uri = new Uri("/login", UriKind.Relative);
            _httpClient.DefaultRequestHeaders.Referrer = _httpClient.BaseAddress;
            var httpResponseMessage = await _httpClient.PostAsync(uri, bodyContent);
            return IsAuthenticated();
        }

        public override async Task<bool> AddMagnet(string magnet, string path, string label = null)
        {
            return await AddTorrentByUrl(magnet, path, label);
        }

        public override async Task<bool> AddTorrentByUrl(string torrentUrl, string path, string label = null)
        {
            await CheckAuthentification();

            var stringBuilder = new StringBuilder();

            HttpContent bodyContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("urls", torrentUrl),
                new KeyValuePair<string, string>("savepath", path),
                new KeyValuePair<string, string>("category", label)
            });

            var uriDownload = new Uri("/command/download", UriKind.Relative);
            var httpResponseMessage = await _httpClient.PostAsync(uriDownload, bodyContent);

            return httpResponseMessage.IsSuccessStatusCode;
        }

        protected override bool IsAuthenticated()
        {
            //var headers = X-Request:JSON
            //X - Requested - With:XMLHttpRequest
            var uri = new Uri("/query/transferInfo", UriKind.Relative);
            var httpResponseMessage = _httpClient.GetAsync(uri).Result;

            return httpResponseMessage.IsSuccessStatusCode;
        }
    }
}