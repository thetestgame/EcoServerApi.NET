// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface ILawApi
    {
        [Get("/api/v1/laws/byStates/{states}")]
        Task<EcoWebCoreDataTransferObjectsV1LawV1[]> LawList(string states);

        [Get("/api/v1/laws")]
        Task<EcoWebCoreDataTransferObjectsV1LawV1[]> LawListAll();

        [Get("/api/v1/laws/districtmap/{name}")]
        Task<EcoWebCoreDataTransferObjectsV1DistrictMapV1> LawGetDistrictMap(string name);

        [Get("/api/v1/laws/{id}")]
        Task<EcoWebCoreDataTransferObjectsV1LawV1> LawGetLaw(int id);

        [Post("/api/v1/laws/generatetestdata")]
        Task LawGenerateTestData([Query] string authtoken, [Query] string authtokentype);
    }
}
