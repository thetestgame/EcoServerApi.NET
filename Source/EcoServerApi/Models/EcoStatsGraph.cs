// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoStatsGraph
    {
        [JsonPropertyName("Keys")]
        public EcoStatsKey[] Keys { get; set; }

        [JsonPropertyName("TimeMin")]
        public double TimeMin { get; set; }

        [JsonPropertyName("TimeMax")]
        public double TimeMax { get; set; }
    }
}
