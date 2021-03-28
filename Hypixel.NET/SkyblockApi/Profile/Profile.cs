using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.SkyblockApi.Profile
{
    public class Profile
    {
        [JsonProperty("profile_id")] public string ProfileId { get; set; }

        [JsonProperty("members")] public Dictionary<string, MemberList> Members { get; set; }
    }
}