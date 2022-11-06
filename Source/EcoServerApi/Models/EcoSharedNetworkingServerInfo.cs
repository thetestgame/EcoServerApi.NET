// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoSharedNetworkingServerInfo
    {
        [JsonPropertyName("Id")]
        public object Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Address")]
        public string Address { get; set; }

        [JsonPropertyName("External")]
        public bool External { get; set; }

        [JsonPropertyName("GamePort")]
        public int GamePort { get; set; }

        [JsonPropertyName("WebPort")]
        public int WebPort { get; set; }

        [JsonPropertyName("IsLAN")]
        public bool IsLAN { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("DetailedDescription")]
        public string DetailedDescription { get; set; }

        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("OnlinePlayers")]
        public int OnlinePlayers { get; set; }

        [JsonPropertyName("TotalPlayers")]
        public int TotalPlayers { get; set; }

        [JsonPropertyName("OnlinePlayersNames")]
        public string[] OnlinePlayersNames { get; set; }

        [JsonPropertyName("AdminOnline")]
        public bool AdminOnline { get; set; }

        [JsonPropertyName("TimeSinceStart")]
        public double TimeSinceStart { get; set; }

        [JsonPropertyName("TimeLeft")]
        public double TimeLeft { get; set; }

        [JsonPropertyName("Animals")]
        public int Animals { get; set; }

        [JsonPropertyName("Plants")]
        public int Plants { get; set; }

        [JsonPropertyName("Laws")]
        public int Laws { get; set; }

        [JsonPropertyName("WorldSize")]
        public string WorldSize { get; set; }

        [JsonPropertyName("Version")]
        public string Version { get; set; }

        [JsonPropertyName("EconomyDesc")]
        public string EconomyDesc { get; set; }

        [JsonPropertyName("SkillSpecialization")]
        public string SkillSpecialization { get; set; }

        [JsonPropertyName("SkillSpecializationSetting")]
        public string SkillSpecializationSetting { get; set; }

        [JsonPropertyName("WorldObjective")]
        public string WorldObjective { get; set; }

        [JsonPropertyName("Language")]
        public string Language { get; set; }

        [JsonPropertyName("HasPassword")]
        public bool HasPassword { get; set; }

        [JsonPropertyName("HasMeteor")]
        public bool HasMeteor { get; set; }

        [JsonPropertyName("DistributionStationItems")]
        public string DistributionStationItems { get; set; }

        [JsonPropertyName("Playtimes")]
        public string Playtimes { get; set; }

        [JsonPropertyName("DiscordAddress")]
        public string DiscordAddress { get; set; }

        [JsonPropertyName("IsPaused")]
        public bool IsPaused { get; set; }

        [JsonPropertyName("ActiveAndOnlinePlayers")]
        public int ActiveAndOnlinePlayers { get; set; }

        [JsonPropertyName("PeakActivePlayers")]
        public int PeakActivePlayers { get; set; }

        [JsonPropertyName("MaxActivePlayers")]
        public int MaxActivePlayers { get; set; }

        [JsonPropertyName("ShelfLifeMultiplier")]
        public float ShelfLifeMultiplier { get; set; }

        [JsonPropertyName("ExhaustionAfterHours")]
        public float ExhaustionAfterHours { get; set; }

        [JsonPropertyName("IsLimitingHours")]
        public bool IsLimitingHours { get; set; }

        [JsonPropertyName("ServerAchievements")]
        public string[] ServerAchievements { get; set; }

        [JsonPropertyName("RelayAddress")]
        public string RelayAddress { get; set; }

        [JsonPropertyName("Access")]
        public string Access { get; set; }

        [JsonPropertyName("JoinUrl")]
        public string JoinUrl { get; set; }
    }
}
