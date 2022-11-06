// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoStatsStatInfo
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("DisplayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("Unit")]
        public string Unit { get; set; }

        [JsonPropertyName("UnitDisplayName")]
        public string UnitDisplayName { get; set; }

        [JsonPropertyName("StatType")]
        public string StatType { get; set; }

        [JsonPropertyName("ShortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Tags")]
        public string[] Tags { get; set; }

        [JsonPropertyName("ValueKey")]
        public string ValueKey { get; set; }

        [JsonPropertyName("SystemType")]
        public string SystemType { get; set; }

        [JsonPropertyName("HasValueKey")]
        public bool HasValueKey { get; set; }

        [JsonPropertyName("IsCustom")]
        public bool IsCustom { get; set; }

        [JsonPropertyName("IsAction")]
        public bool IsAction { get; set; }

        [JsonPropertyName("IsCountable")]
        public bool IsCountable { get; set; }

        [JsonPropertyName("IsAggregatable")]
        public bool IsAggregatable { get; set; }

        [JsonPropertyName("TimeKey")]
        public string TimeKey { get; set; }
    }
}
