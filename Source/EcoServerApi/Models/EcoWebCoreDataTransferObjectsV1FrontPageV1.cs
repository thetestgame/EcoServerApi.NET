// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1FrontPageV1
    {
        [JsonPropertyName("Info")]
        public EcoSharedNetworkingServerInfo Info { get; set; }

        [JsonPropertyName("Graphs")]
        public EcoStatsNamedGraph[] Graphs { get; set; }
    }
}
