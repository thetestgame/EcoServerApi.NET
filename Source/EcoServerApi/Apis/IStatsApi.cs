// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface IStatsApi
    {
        [Get("/datasets/timerange")]
        Task<float[]> StatsGetTimeRange([Query] string authtoken, [Query] string authtokentype);

        [Get("/datasets/treelist")]
        Task<EcoStatsStatCategory> StatsGetTreeList([Query] string authtoken, [Query] string authtokentype);

        [Get("/datasets/flatlist")]
        Task<EcoStatsStatInfo[]> StatsGetFlatList([Query] string authtoken, [Query] string authtokentype);

        [Get("/datasets/get")]
        Task<EcoWebServerWebControllersStatReturn> StatsGet([Query] string authtoken, [Query] string authtokentype, [Query] string dataset, [Query] double? dayStart, [Query] double? dayEnd);

        [Get("/datasets/getlist")]
        Task<EcoWebServerWebControllersStatReturn[]> StatsGetList([Query] string authtoken, [Query] string authtokentype, [Query] string[] requestedSets, [Query] double? dayStart, [Query] double? dayEnd);

        [Get("/datasets/graphs")]
        Task<EcoStatsNamedGraph[]> StatsGraphs([Query] string authtoken, [Query] string authtokentype);

        [Get("/datasets/generatetestdata")]
        Task StatsGenerateTestData([Query] string authtoken, [Query] string authtokentype, [Query] float? days, [Query] int? users, [Query] bool? generateClimateData, [Query] float? pollutionMultiplier);
    }
}
