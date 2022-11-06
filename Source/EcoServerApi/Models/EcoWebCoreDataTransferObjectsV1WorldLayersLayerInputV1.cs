// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1WorldLayersLayerInputV1
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Color")]
        public EcoSharedUtilsColor Color { get; set; }

        [JsonPropertyName("DoubleEnded")]
        public bool DoubleEnded { get; set; }
    }
}
