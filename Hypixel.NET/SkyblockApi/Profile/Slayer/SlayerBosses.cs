using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class SlayerBosses
    {
        [JsonProperty("zombie")] public Zombie Zombie { get; set; }

        [JsonProperty("spider")] public Spider Spider { get; set; }

        [JsonProperty("wolf")] public Wolf Wolf { get; set; }
    }
}