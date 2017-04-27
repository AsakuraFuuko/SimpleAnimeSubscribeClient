using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSubscribeClient.model
{
    public class Episode
    {
        [JsonProperty(PropertyName = "_id")]
        public string ID { get; set; }

        public string Name { get; set; }
        public string Title { get; set; }
        public string Torrent { get; set; }
        public string Magnet { get; set; }
    }
}