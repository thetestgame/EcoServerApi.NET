// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebServerWebControllersStatReturn
    {
        [JsonPropertyName("Times")]
        public int[] Times { get; set; }

        [JsonPropertyName("Values")]
        public float[] Values { get; set; }

        [JsonPropertyName("Interval")]
        public double Interval { get; set; }

        [JsonPropertyName("Unit")]
        public string Unit { get; set; }
    }
}
