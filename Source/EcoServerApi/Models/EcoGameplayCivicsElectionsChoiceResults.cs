// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoGameplayCivicsElectionsChoiceResults
    {
        [JsonPropertyName("ChoiceID")]
        public int ChoiceID { get; set; }

        [JsonPropertyName("MarkedUpName")]
        public string MarkedUpName { get; set; }

        [JsonPropertyName("VotesPerRound")]
        public float[] VotesPerRound { get; set; }

        [JsonPropertyName("Votes")]
        public float Votes { get; set; }

        [JsonPropertyName("SimpleResultVotes")]
        public float SimpleResultVotes { get; set; }
    }
}
