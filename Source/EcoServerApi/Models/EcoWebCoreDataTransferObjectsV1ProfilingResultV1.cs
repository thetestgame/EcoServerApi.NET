// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1ProfilingResultV1
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Size")]
        public long Size { get; set; }

        [JsonPropertyName("CreatedAt")]
        public string CreatedAt { get; set; }
    }
}
