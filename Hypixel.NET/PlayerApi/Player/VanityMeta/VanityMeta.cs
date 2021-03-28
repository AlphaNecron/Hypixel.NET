using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.VanityMeta
{
    public class VanityMeta
    {
        [JsonProperty("packages")] public List<string> Packages { get; private set; }
    }
}