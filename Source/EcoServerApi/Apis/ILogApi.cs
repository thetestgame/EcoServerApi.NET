// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

namespace EcoServerApi.Apis
{
    public interface ILogApi
    {
        [Get("/api/v1/logs")]
        Task<string[]> LogGetAllLogs([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/logs/{category}")]
        Task<string[]> LogGetCategoryLogs(string category, [Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/logs/get")]
        Task LogGetLogFile([Query] string authtoken, [Query] string authtokentype, [Query] string filepath);
    }
}
