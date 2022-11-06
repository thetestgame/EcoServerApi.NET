// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1ExecuteCommandV1
    {
        [JsonPropertyName("Command")]
        public string Command { get; set; }
    }
}
