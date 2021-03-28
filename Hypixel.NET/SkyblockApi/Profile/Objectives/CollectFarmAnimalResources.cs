using System;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile.Objectives
{
    public class CollectFarmAnimalResources
    {
        [JsonProperty("completed_at")] private readonly long _completedAt;
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

        [JsonProperty("RAW_CHICKEN")] public bool RawChicken { get; private set; }

        [JsonProperty("LEATHER")] public bool Leather { get; private set; }

        [JsonProperty("PORK")] public bool Pork { get; private set; }
    }
}