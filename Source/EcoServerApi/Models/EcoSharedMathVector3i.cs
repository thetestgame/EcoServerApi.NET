// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoSharedMathVector3i
    {
        [JsonPropertyName("x")]
        public int X { get; set; }

        [JsonPropertyName("y")]
        public int Y { get; set; }

        [JsonPropertyName("z")]
        public int Z { get; set; }

        [JsonPropertyName("Magnitude")]
        public float Magnitude { get; set; }

        [JsonPropertyName("SqrMagnitude")]
        public int SqrMagnitude { get; set; }

        [JsonPropertyName("MultTogether")]
        public int MultTogether { get; set; }

        [JsonPropertyName("XZ")]
        public EcoSharedMathVector2i XZ { get; set; }

        [JsonPropertyName("XZFullNeighborsAndSelf")]
        public EcoSharedMathVector3i[] XZFullNeighborsAndSelf { get; set; }

        [JsonPropertyName("XZNeighborsAndSelf")]
        public EcoSharedMathVector3i[] XZNeighborsAndSelf { get; set; }

        [JsonPropertyName("XZNeighborsAndDir")]
        public EcoSharedMathRay[] XZNeighborsAndDir { get; set; }

        [JsonPropertyName("XZNeighbors")]
        public EcoSharedMathVector3i[] XZNeighbors { get; set; }

        [JsonPropertyName("XZFullNeighbors")]
        public EcoSharedMathVector3i[] XZFullNeighbors { get; set; }

        [JsonPropertyName("XYZNeighborsAndSelf")]
        public EcoSharedMathVector3i[] XYZNeighborsAndSelf { get; set; }

        [JsonPropertyName("XYZNeighbors")]
        public EcoSharedMathVector3i[] XYZNeighbors { get; set; }

        [JsonPropertyName("Full26Neighbors")]
        public EcoSharedMathVector3i[] Property_Full26Neighbors { get; set; }

        [JsonPropertyName("Normalized")]
        public SystemNumericsVector3 Normalized { get; set; }

        [JsonPropertyName("NormalizedOrZero")]
        public SystemNumericsVector3 NormalizedOrZero { get; set; }
    }
}
