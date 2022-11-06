// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1CommandResultV1
    {
        [JsonPropertyName("CommandMessages")]
        public EcoWebCoreDataTransferObjectsV1CommandMessageV1[] CommandMessages { get; set; }

        [JsonPropertyName("OriginalCommand")]
        public string OriginalCommand { get; set; }

        [JsonPropertyName("Errored")]
        public bool Errored { get; set; }
    }
}
