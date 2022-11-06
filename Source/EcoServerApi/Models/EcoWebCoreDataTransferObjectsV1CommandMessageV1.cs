// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1CommandMessageV1
    {
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Message")]
        public string Message { get; set; }
    }
}
