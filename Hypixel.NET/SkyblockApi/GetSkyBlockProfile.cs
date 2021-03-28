using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi
{
    public class GetSkyBlockProfile
    {
        public bool FromCache;

        [JsonProperty("success")] public bool WasSuccessful { get; private set; }

        [JsonProperty("profile")] public Profile.Profile Profile { get; private set; }
    }
}