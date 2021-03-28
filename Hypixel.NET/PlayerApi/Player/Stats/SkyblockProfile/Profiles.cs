using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.Stats.SkyblockProfile
{
    public class SkyblockProfile
    {
        [JsonProperty("profile_id")] public string ProfileId { get; private set; }

        [JsonProperty("cute_name")] public string CuteName { get; private set; }
    }
}