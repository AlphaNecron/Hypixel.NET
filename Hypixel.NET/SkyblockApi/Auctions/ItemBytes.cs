using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Auctions
{
    public class ItemBytes
    {
        [JsonProperty("type")] public long Type { get; private set; }

        [JsonProperty("data")] public string Data { get; private set; }
    }
}