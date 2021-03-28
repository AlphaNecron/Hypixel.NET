using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats
{
    public class Skyblock
    {
        [JsonProperty("profiles")]
        public Dictionary<string, SkyblockProfile.SkyblockProfile> Profiles { get; private set; }
    }
}