// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1EntityV1
    {
        [JsonPropertyName("Position")]
        public SystemNumericsVector3 Position { get; set; }

        [JsonPropertyName("EntityType")]
        public string EntityType { get; set; }
    }
}
