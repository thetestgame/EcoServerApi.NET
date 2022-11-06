// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1WorldLayersWorldLayerGroupV1
    {
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("List")]
        public EcoWebCoreDataTransferObjectsV1WorldLayersWorldLayerV1[] List { get; set; }
    }
}
