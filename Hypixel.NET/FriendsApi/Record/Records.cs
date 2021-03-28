using System;
using Newtonsoft.Json;

namespace Hypixel.NET.FriendsApi.Record
{
    public class Records
    {
        [JsonProperty("started")] private readonly long _started;
        [JsonProperty("uuidSender")] public string UuidSender { get; private set; }

        [JsonProperty("uuidReceiver")] public string UuidReceiver { get; private set; }

        public DateTime Started
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_started).ToLocalTime();
                return convertToDateTime;
            }
        }
    }
}