// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1GameServerElectionV1
    {
        [JsonPropertyName("Choices")]
        public EcoWebCoreDataTransferObjectsV1ElectionChoiceV1[] Choices { get; set; }

        [JsonPropertyName("TotalVotes")]
        public int TotalVotes { get; set; }

        [JsonPropertyName("TimeEnd")]
        public double TimeEnd { get; set; }

        [JsonPropertyName("TimeEndAgo")]
        public double TimeEndAgo { get; set; }

        [JsonPropertyName("TimeStart")]
        public double TimeStart { get; set; }

        [JsonPropertyName("TimeStartAgo")]
        public double TimeStartAgo { get; set; }

        [JsonPropertyName("Finished")]
        public bool Finished { get; set; }

        [JsonPropertyName("Passed")]
        public bool Passed { get; set; }

        [JsonPropertyName("PendingVote")]
        public bool PendingVote { get; set; }

        [JsonPropertyName("Comments")]
        public EcoWebCoreDataTransferObjectsV1ElectionCommentV1[] Comments { get; set; }

        [JsonPropertyName("Provisions")]
        public EcoWebCoreDataTransferObjectsV1CivicActionV1[] Provisions { get; set; }

        [JsonPropertyName("Results")]
        public EcoWebCoreDataTransferObjectsV1ElectionResultsV1 Results { get; set; }

        [JsonPropertyName("ElectionProcess")]
        public EcoWebCoreDataTransferObjectsV1ElectionProcessV1 ElectionProcess { get; set; }

        [JsonPropertyName("PositionForWinner")]
        public EcoWebCoreDataTransferObjectsV1ElectedTitleV1 PositionForWinner { get; set; }

        [JsonPropertyName("BooleanElection")]
        public bool BooleanElection { get; set; }

        [JsonPropertyName("ElectionDescription")]
        public string ElectionDescription { get; set; }

        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("UserDescription")]
        public string UserDescription { get; set; }

        [JsonPropertyName("State")]
        public string State { get; set; }

        [JsonPropertyName("Creator")]
        public string Creator { get; set; }
    }
}
