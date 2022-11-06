// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1ElectionResultsV1
    {
        [JsonPropertyName("ChoiceRanks")]
        public EcoGameplayCivicsElectionsChoiceResults[] ChoiceRanks { get; set; }

        [JsonPropertyName("TotalVotesForWinner")]
        public float TotalVotesForWinner { get; set; }

        [JsonPropertyName("Winners")]
        public string[] Winners { get; set; }

        [JsonPropertyName("Result")]
        public string Result { get; set; }

        [JsonPropertyName("Finished")]
        public bool Finished { get; set; }
    }
}
