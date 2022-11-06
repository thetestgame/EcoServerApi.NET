// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1CivicActionV1
    {
        [JsonPropertyName("ActionOnComplete")]
        public string ActionOnComplete { get; set; }

        [JsonPropertyName("ActionOnCompleteTableHeader")]
        public string ActionOnCompleteTableHeader { get; set; }

        [JsonPropertyName("ActionOnCompleteTable")]
        public EcoSharedLocalizationLocString[] ActionOnCompleteTable { get; set; }

        [JsonPropertyName("ActionOnCompleteFullDescription")]
        public string ActionOnCompleteFullDescription { get; set; }

        [JsonPropertyName("DistrictMapBefore")]
        public EcoWebCoreDataTransferObjectsV1MapV1 DistrictMapBefore { get; set; }

        [JsonPropertyName("DistrictMapAfter")]
        public EcoWebCoreDataTransferObjectsV1MapV1 DistrictMapAfter { get; set; }
    }
}
