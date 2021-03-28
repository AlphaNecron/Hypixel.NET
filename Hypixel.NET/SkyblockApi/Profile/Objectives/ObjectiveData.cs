using System;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile.Objectives
{
    public class ObjectiveData
    {
        [JsonProperty("completed_at")] public readonly long _completedAt;
        [JsonProperty("status")] public string Status { get; private set; }

        [JsonProperty("progress")] public long Progress { get; private set; }

        public DateTime CompletedAt
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_completedAt).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("DIAMOND", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Diamond { get; private set; }

        [JsonProperty("EMERALD", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emerald { get; private set; }

        [JsonProperty("INK_SACK:4", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InkSack4 { get; private set; }

        [JsonProperty("OBSIDIAN", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Obsidian { get; private set; }

        [JsonProperty("REDSTONE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Redstone { get; private set; }

        [JsonProperty("ENDER_STONE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnderStone { get; private set; }
    }
}