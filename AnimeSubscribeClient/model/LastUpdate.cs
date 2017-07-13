using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSubscribeClient.model
{
    public class LastUpdate
    {
        public bool Status { get; set; }

        [JsonProperty(PropertyName = "result")]
        public long LastUpdateTime { get; set; }
    }
}
