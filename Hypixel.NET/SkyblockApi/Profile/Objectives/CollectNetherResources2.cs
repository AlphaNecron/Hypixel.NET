using System;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile.Objectives
{
    public class CollectNetherResources2
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

        [JsonProperty("MAGMA_CREAM")] public bool MagmaCream { get; private set; }

        [JsonProperty("GLOWSTONE_DUST")] public bool GlowstoneDust { get; private set; }

        [JsonProperty("QUARTZ")] public bool Quartz { get; private set; }
    }
}