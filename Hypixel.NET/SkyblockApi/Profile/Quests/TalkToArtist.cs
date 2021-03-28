using System;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class TalkToArtist
    {
        [JsonProperty("activated_at")] private readonly long _activatedAt;

        [JsonProperty("completed_at")] private readonly long _completedAt;
        [JsonProperty("status")] public string Status { get; private set; }

        public DateTime ActivatedAt
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_activatedAt).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("activated_at_sb")] public long ActivatedAtSb { get; private set; }

        public DateTime CompletedAt
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_completedAt).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("completed_at_sb")] public long CompletedAtSb { get; private set; }
    }
}