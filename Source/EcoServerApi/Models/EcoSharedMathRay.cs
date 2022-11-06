// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoSharedMathRay
    {
        [JsonPropertyName("Pos")]
        public EcoSharedMathVector3i Pos { get; set; }

        [JsonPropertyName("Dir")]
        public string Dir { get; set; }

        [JsonPropertyName("FirstPos")]
        public EcoSharedMathVector3i FirstPos { get; set; }

        [JsonPropertyName("FirstRay")]
        public EcoSharedMathRay FirstRay { get; set; }
    }
}
