﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi
{
    public class GetAuctionPage
    {
        [JsonProperty("lastUpdated")] private readonly long _lastUpdated;
        [JsonProperty("success")] public bool WasSuccessful { get; private set; }

        [JsonProperty("cause")] public string Cause { get; private set; }

        [JsonProperty("page")] public long Page { get; private set; }

        [JsonProperty("totalPages")] public long TotalPages { get; private set; }

        [JsonProperty("totalAuctions")] public long TotalAuctions { get; private set; }

        public DateTime LastUpdated
        {
            get
            {
                var convertToDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                convertToDateTime = convertToDateTime.AddMilliseconds(_lastUpdated).ToLocalTime();
                return convertToDateTime;
            }
        }

        [JsonProperty("auctions")] public List<Auction> Auctions { get; private set; }
    }
}