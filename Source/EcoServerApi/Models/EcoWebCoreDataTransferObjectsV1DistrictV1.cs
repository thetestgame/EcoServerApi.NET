// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1DistrictV1
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("R")]
        public int R { get; set; }

        [JsonPropertyName("G")]
        public int G { get; set; }

        [JsonPropertyName("B")]
        public int B { get; set; }
    }
}
