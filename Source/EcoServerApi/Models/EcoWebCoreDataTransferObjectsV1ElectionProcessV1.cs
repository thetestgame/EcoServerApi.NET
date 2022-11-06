// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1ElectionProcessV1
    {
        [JsonPropertyName("Table")]
        public EcoSharedLocalizationLocString[] Table { get; set; }

        [JsonPropertyName("OccupantNames")]
        public string[] OccupantNames { get; set; }

        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("UserDescription")]
        public string UserDescription { get; set; }

        [JsonPropertyName("State")]
        public string State { get; set; }

        [JsonPropertyName("Creator")]
        public string Creator { get; set; }
    }
}
