// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1ChatMessageV1
    {
        [JsonPropertyName("Timestamp")]
        public double Timestamp { get; set; }

        [JsonPropertyName("Sender")]
        public string Sender { get; set; }

        [JsonPropertyName("Receiver")]
        public string Receiver { get; set; }

        [JsonPropertyName("Text")]
        public string Text { get; set; }
    }
}
