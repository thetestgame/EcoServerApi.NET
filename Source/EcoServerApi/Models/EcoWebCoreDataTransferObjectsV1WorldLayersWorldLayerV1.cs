// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1WorldLayersWorldLayerV1
    {
        [JsonPropertyName("LayerName")]
        public string LayerName { get; set; }

        [JsonPropertyName("LayerDisplayName")]
        public string LayerDisplayName { get; set; }

        [JsonPropertyName("Summary")]
        public string Summary { get; set; }

        [JsonPropertyName("Tooltip")]
        public string Tooltip { get; set; }

        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("DisplayRow")]
        public int DisplayRow { get; set; }
    }
}
