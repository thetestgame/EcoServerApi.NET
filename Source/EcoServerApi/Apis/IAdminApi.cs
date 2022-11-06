// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using EcoServerApi.Models;
using Refit;
using System.Threading.Tasks;

namespace EcoServerApi.Apis
{
    public interface IAdminApi
    {
        [Post("/api/v1/admin/set/access")]
        Task AdminPostSetAccess([Query] string authtoken, [Query] string authtokentype, [Query] string value, [Query] string password);

        [Get("/api/v1/admin/get/access")]
        Task<string> AdminGetGetAccess([Query] string authtoken, [Query] string authtokentype);

        [Post("/api/v1/admin/set/servername")]
        Task AdminPostSetServerName([Query] string authtoken, [Query] string authtokentype, [Query] string name);

        [Get("/api/v1/admin/get/servername")]
        Task<string> AdminGetGetServerName();

        [Post("/api/v1/admin/game/export")]
        Task<EcoWebServerWebModelsAdminReturnModel> AdminPostGameExport([Body] EcoWebServerWebModelsExportGameModel body, [Query] string authtoken, [Query] string authtokentype);
    }
}
