// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface IRootApi
    {
        [Get("/info")]
        Task<EcoSharedNetworkingServerInfo> RootGetInfo([Query] string authtoken, [Query] string authtokentype);

        [Get("/frontpage")]
        Task<EcoWebCoreDataTransferObjectsV1FrontPageV1> RootFrontPage([Query] string authtoken, [Query] string authtokentype);

        [Get("/admins")]
        Task<string[]> RootGetAdmins([Query] string authtoken, [Query] string authtokentype);

        [Get("/isadmin")]
        Task<bool> RootIsAdmin([Query] string authtoken, [Query] string authtokentype);
    }
}
