// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface IProfilingResultsApi
    {
        [Get("/api/v1/profiling-results")]
        Task<EcoWebCoreDataTransferObjectsV1ProfilingResultV1[]> ProfilingResultsList([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/profiling-results/{filename}")]
        Task ProfilingResultsDownload(string filename, [Query] string authtoken, [Query] string authtokentype);
    }
}
