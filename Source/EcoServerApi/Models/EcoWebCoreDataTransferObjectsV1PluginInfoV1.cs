// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1PluginInfoV1
    {
        [JsonPropertyName("TypeName")]
        public string TypeName { get; set; }

        [JsonPropertyName("Status")]
        public string Status { get; set; }

        [JsonPropertyName("HasConfig")]
        public bool HasConfig { get; set; }
    }
}
