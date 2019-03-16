﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.LeaderboardsApi.Leaderboard
{
    public class LeaderboardData
    {
        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("leaders")]
        public List<string> Leaders { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}