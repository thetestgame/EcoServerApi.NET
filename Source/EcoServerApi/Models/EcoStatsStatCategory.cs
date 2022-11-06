// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoStatsStatCategory
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("DisplayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("ChildrenStats")]
        public EcoStatsStatInfo[] ChildrenStats { get; set; }

        [JsonPropertyName("ChildrenCategories")]
        public EcoStatsStatCategory[] ChildrenCategories { get; set; }
    }
}
