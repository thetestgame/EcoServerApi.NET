// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoStatsNamedGraph
    {
        [JsonPropertyName("Category")]
        public EcoSharedLocalizationLocString Category { get; set; }

        [JsonPropertyName("Name")]
        public EcoSharedLocalizationLocString Name { get; set; }

        [JsonPropertyName("Graph")]
        public EcoStatsGraph Graph { get; set; }
    }
}
