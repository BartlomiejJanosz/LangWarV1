using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangWarV1
{
    public class Player
    {
        //[JsonProperty("playerId")]
        //public int PlayerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("option")]
        public bool JoinToExistingGame { get; set; }
    }
}
