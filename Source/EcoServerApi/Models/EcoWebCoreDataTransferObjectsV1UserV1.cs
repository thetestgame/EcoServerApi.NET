// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1UserV1
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("SlgId")]
        public string SlgId { get; set; }

        [JsonPropertyName("SteamId")]
        public string SteamId { get; set; }
    }
}
