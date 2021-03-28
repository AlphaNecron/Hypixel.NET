using Newtonsoft.Json;

namespace Hypixel.NET.PlayerApi.Player.GameCounts
{
    public class GetGameCounts
    {
        [JsonProperty("games")] public Games.Games Games { get; set; }

        [JsonProperty("cause")] public string Cause { get; private set; }

        [JsonProperty("success")] public bool WasSuccessful { get; private set; }

        [JsonProperty("playerCount")] public long HypixelPlayerCount { get; private set; }
    }
}