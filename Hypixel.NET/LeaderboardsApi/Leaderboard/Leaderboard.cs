using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hypixel.NET.LeaderboardsApi.Leaderboard
{
    public class Leaderboard
    {
        [JsonProperty("ARCADE")] public List<LeaderboardData> Arcade;

        [JsonProperty("ARENA")] public List<LeaderboardData> Arena;

        [JsonProperty("BEDWARS")] public List<LeaderboardData> BedWars;

        [JsonProperty("SURVIVAL_GAMES")] public List<LeaderboardData> BlitzSg;

        [JsonProperty("BUILD_BATTLE")] public List<LeaderboardData> BuildBattle;

        [JsonProperty("MCGO")] public List<LeaderboardData> CopsAndCrims;

        [JsonProperty("DUELS")] public List<LeaderboardData> Duels;

        [JsonProperty("MURDER_MYSTERY")] public List<LeaderboardData> MurderMystery;

        [JsonProperty("PAINTBALL")] public List<LeaderboardData> PaintBall;

        [JsonProperty("QUAKECRAFT")] public List<LeaderboardData> Quake;

        [JsonProperty("SKYCLASH")] public List<LeaderboardData> SkyClash;

        [JsonProperty("SKYWARS")] public List<LeaderboardData> SkyWars;

        [JsonProperty("SUPER_SMASH")] public List<LeaderboardData> Smash;

        [JsonProperty("SPEED_UHC")] public List<LeaderboardData> SpeedUhc;
        [JsonProperty("TNTGAMES")] public List<LeaderboardData> TntGames;

        [JsonProperty("TRUE_COMBAT")] public List<LeaderboardData> TrueCombat;

        [JsonProperty("GINGERBREAD")] public List<LeaderboardData> TurboKartRacers;

        [JsonProperty("UHC")] public List<LeaderboardData> Uhc;

        [JsonProperty("VAMPIREZ")] public List<LeaderboardData> VampireZ;

        [JsonProperty("WALLS")] public List<LeaderboardData> Walls;

        [JsonProperty("WALLS3")] public List<LeaderboardData> Walls3;

        [JsonProperty("BATTLEGROUND")] public List<LeaderboardData> Warlords;
    }
}