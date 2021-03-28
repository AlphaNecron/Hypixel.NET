using System;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile.Objectives
{
    public class CollectIngots
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

        [JsonProperty("IRON_INGOT")] public bool IronIngot { get; private set; }

        [JsonProperty("GOLD_INGOT")] public bool GoldIngot { get; private set; }
    }
}