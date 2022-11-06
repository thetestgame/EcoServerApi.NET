// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoStatsKey
    {
        [JsonPropertyName("Unit")]
        public string Unit { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }

        [JsonPropertyName("UnitDisplayName")]
        public string UnitDisplayName { get; set; }

        [JsonPropertyName("DisplayName")]
        public string DisplayName { get; set; }
    }
}
