﻿using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class InvArmour
    {
        [JsonProperty("type")] public long Type { get; private set; }

        [JsonProperty("data")] public string Data { get; private set; }
    }
}