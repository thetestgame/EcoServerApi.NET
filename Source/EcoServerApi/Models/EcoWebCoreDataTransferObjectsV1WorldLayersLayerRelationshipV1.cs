// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1WorldLayersLayerRelationshipV1
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("RelationshipType")]
        public string RelationshipType { get; set; }

        [JsonPropertyName("Output")]
        public string Output { get; set; }

        [JsonPropertyName("Inputs")]
        public EcoWebCoreDataTransferObjectsV1WorldLayersLayerInputV1[] Inputs { get; set; }

        [JsonPropertyName("HiddenInputs")]
        public string[] HiddenInputs { get; set; }

        [JsonPropertyName("Tooltip")]
        public string Tooltip { get; set; }

        [JsonPropertyName("Guid")]
        public string Guid { get; set; }
    }
}
