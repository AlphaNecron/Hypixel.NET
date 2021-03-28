using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi
{
    public class AuctionsByProfile
    {
        public bool FromCache;

        [JsonProperty("success")] public bool WasSuccessful { get; private set; }

        [JsonProperty("auctions")] public List<Auctions.Auction> Auctions { get; private set; }
    }
}