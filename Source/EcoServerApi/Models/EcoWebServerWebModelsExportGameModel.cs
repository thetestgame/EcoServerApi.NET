// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebServerWebModelsExportGameModel
    {
        [JsonPropertyName("S3ExportUri")]
        public string Property_S3ExportUri { get; set; }
    }
}
