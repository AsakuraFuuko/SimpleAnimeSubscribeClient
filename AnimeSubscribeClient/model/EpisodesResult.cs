using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSubscribeClient.model
{
    public class EpisodesResult
    {
        public bool Status { get; set; }

        [JsonProperty(PropertyName = "result")]
        public List<Episode> Episodes { get; set; }
    }
}