// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface IElectionApi
    {
        [Get("/api/v1/elections/titles")]
        Task<EcoWebCoreDataTransferObjectsV1ElectedTitleV1[]> ElectionListElectedTitles([Query] object state);

        [Get("/api/v1/elections")]
        Task<EcoWebCoreDataTransferObjectsV1GameServerElectionV1[]> ElectionListElections([Query] bool? returnActive);

        [Get("/api/v1/elections/{id}")]
        Task<EcoWebCoreDataTransferObjectsV1GameServerElectionV1> ElectionGetElectionById(int id);

        [Get("/api/v1/elections/titles/{id}")]
        Task<EcoWebCoreDataTransferObjectsV1ElectedTitleV1> ElectionGetElectedTitleById(int id);

        [Get("/api/v1/elections/votes")]
        Task<EcoWebCoreDataTransferObjectsV1RunoffVoteV1[]> ElectionVotes([Query] int? id);

        [Post("/api/v1/elections/vote")]
        Task ElectionVote([Body] EcoWebCoreDataTransferObjectsV1RunoffVoteV1 body, [Query] string authtoken, [Query] string authtokentype, [Query] bool? forceVote);

        [Post("/api/v1/elections/forceelectionend")]
        Task ElectionForceElectionEnd([Query] string authtoken, [Query] string authtokentype, [Query] int? electionId);

        [Post("/api/v1/elections/addcomment")]
        Task ElectionAddComment([Body] EcoWebCoreDataTransferObjectsV1ElectionCommentV1 body, [Query] string authtoken, [Query] string authtokentype, [Query] int? electionId);

        [Get("/api/v1/elections/listcomments")]
        Task<EcoWebCoreDataTransferObjectsV1ElectionCommentV1[]> ElectionGetComments([Query] int? electionId);

        [Post("/api/v1/elections/generatetestdata")]
        Task ElectionGenerateTestData([Query] string authtoken, [Query] string authtokentype);

        [Post("/api/v1/elections/finishelection")]
        Task ElectionFinishElection([Query] string authtoken, [Query] string authtokentype);
    }
}
