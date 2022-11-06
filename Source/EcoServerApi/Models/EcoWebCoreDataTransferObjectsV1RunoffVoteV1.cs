// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1RunoffVoteV1
    {
        [JsonPropertyName("ElectionID")]
        public int ElectionID { get; set; }

        [JsonPropertyName("Voter")]
        public string Voter { get; set; }

        [JsonPropertyName("RankedVotes")]
        public int[] RankedVotes { get; set; }
    }
}
