// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface IMapApi
    {
        [Get("/api/v1/map/mapstats")]
        Task<EcoWebCoreDataTransferObjectsV1MapStatsV1> MapMapStats([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/map/entitytypes")]
        Task<string[]> MapEntityTypes([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/map/entities")]
        Task<EcoWebCoreDataTransferObjectsV1EntityV1[]> MapEntities([Query] string authtoken, [Query] string authtokentype, [Query] string[] entityTypes, [Query] string[] states);

        [Get("/api/v1/map/dimension")]
        Task<EcoSharedMathVector3i> MapGetDimension([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/map/layerList")]
        Task<string[]> MapLayerList([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/map/map.json")]
        Task MapMakeMapJSON([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/map/waterLevel")]
        Task<float> MapWaterLevel([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/map/property")]
        Task MapGetProperty([Query] string authtoken, [Query] string authtokentype);
    }
}
