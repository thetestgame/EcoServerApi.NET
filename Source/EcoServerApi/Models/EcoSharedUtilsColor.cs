// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoSharedUtilsColor
    {
        [JsonPropertyName("R")]
        public float R { get; set; }

        [JsonPropertyName("G")]
        public float G { get; set; }

        [JsonPropertyName("B")]
        public float B { get; set; }

        [JsonPropertyName("A")]
        public float A { get; set; }

        [JsonPropertyName("UIntUnit2y")]
        public int Property_UIntUnit2y { get; set; }

        [JsonPropertyName("UIntUnity")]
        public int UIntUnity { get; set; }

        [JsonPropertyName("UInt")]
        public int UInt { get; set; }

        [JsonPropertyName("HexRGBA")]
        public string HexRGBA { get; set; }
    }
}
