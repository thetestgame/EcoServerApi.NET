// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

using EcoServerApi.Models;

namespace EcoServerApi.Apis
{
    public interface IWorldLayerApi
    {
        [Get("/api/v1/worldlayers/layers")]
        Task<EcoWebCoreDataTransferObjectsV1WorldLayersWorldLayerGroupV1[]> WorldLayerListLayers([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/worldlayers/layers/{focusLayer}")]
        Task<EcoWebCoreDataTransferObjectsV1WorldLayersWorldLayerV1[]> WorldLayerListRelevantLayers(string focusLayer, [Query] string authtoken, [Query] string authtokentype, [Query] float? minX, [Query] float? minY, [Query] float? maxX, [Query] float? maxY);

        [Get("/api/v1/worldlayers/relationships/areadescription")]
        Task<string> WorldLayerAreaDescription([Query] string authtoken, [Query] string authtokentype, [Query] float? minX, [Query] float? minY, [Query] float? maxX, [Query] float? maxY);

        [Get("/api/v1/worldlayers/relationships/{focusLayer}")]
        Task<EcoWebCoreDataTransferObjectsV1WorldLayersLayerRelationshipV1[]> WorldLayerListRelevantRelationships(string focusLayer, [Query] string authtoken, [Query] string authtokentype, [Query] float? minX, [Query] float? minY, [Query] float? maxX, [Query] float? maxY);
    }
}
