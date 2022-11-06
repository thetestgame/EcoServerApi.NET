// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface IUsersApi
    {
        [Get("/api/v1/users")]
        Task<EcoWebCoreDataTransferObjectsV1UserV1[]> UsersGetUsers([Query] string authtoken, [Query] string authtokentype, [Query] int? hoursPlayedGte);
    }
}
