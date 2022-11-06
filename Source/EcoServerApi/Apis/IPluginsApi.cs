// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface IPluginsApi
    {
        [Get("/api/v1/plugins")]
        Task<EcoWebCoreDataTransferObjectsV1PluginInfoV1[]> PluginsGetPlugins();

        [Get("/api/v1/plugins/{name}")]
        Task PluginsGetPluginConfig(string name, [Query] string authtoken, [Query] string authtokentype);

        [Post("/api/v1/plugins/{name}")]
        Task PluginsPostPluginConfig([Body] object body, string name, [Query] string authtoken, [Query] string authtokentype);
    }
}
