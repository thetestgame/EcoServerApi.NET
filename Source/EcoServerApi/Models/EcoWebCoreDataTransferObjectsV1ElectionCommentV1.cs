// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1ElectionCommentV1
    {
        [JsonPropertyName("Username")]
        public string Username { get; set; }

        [JsonPropertyName("Text")]
        public string Text { get; set; }

        [JsonPropertyName("Graph")]
        public EcoStatsGraph Graph { get; set; }

        [JsonPropertyName("Map")]
        public EcoWebCoreDataTransferObjectsV1MapV1 Map { get; set; }

        [JsonPropertyName("Timestamp")]
        public double Timestamp { get; set; }
    }
}
