// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface ICommandApi
    {
        [Post("/api/v1/command/exec")]
        Task<EcoWebCoreDataTransferObjectsV1CommandResultV1> CommandExecCommand([Body] EcoWebCoreDataTransferObjectsV1ExecuteCommandV1 body, [Query] string authtoken, [Query] string authtokentype);
    }
}
