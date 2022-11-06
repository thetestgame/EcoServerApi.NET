// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoSharedMathVector2i
    {
        [JsonPropertyName("x")]
        public int X { get; set; }

        [JsonPropertyName("y")]
        public int Y { get; set; }

        [JsonPropertyName("Length")]
        public float Length { get; set; }

        [JsonPropertyName("Magnitude")]
        public float Magnitude { get; set; }

        [JsonPropertyName("MagnitudeSq")]
        public float MagnitudeSq { get; set; }

        [JsonPropertyName("Area")]
        public int Area { get; set; }

        [JsonPropertyName("NeighborsAdjacent")]
        public EcoSharedMathVector2i[] NeighborsAdjacent { get; set; }

        [JsonPropertyName("NeighborsDiagonal")]
        public EcoSharedMathVector2i[] NeighborsDiagonal { get; set; }
    }
}
