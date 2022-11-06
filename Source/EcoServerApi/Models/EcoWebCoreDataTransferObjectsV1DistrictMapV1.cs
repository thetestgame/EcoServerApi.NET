// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1DistrictMapV1
    {
        [JsonPropertyName("DistrictMetadata")]
        public EcoWebCoreDataTransferObjectsV1DistrictV1[] DistrictMetadata { get; set; }

        [JsonPropertyName("DistrictMap")]
        public string DistrictMap { get; set; }
    }
}
