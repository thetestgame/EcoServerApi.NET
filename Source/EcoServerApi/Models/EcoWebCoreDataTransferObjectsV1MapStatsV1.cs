// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1MapStatsV1
    {
        [JsonPropertyName("Size")]
        public EcoSharedMathVector3i Size { get; set; }
    }
}
