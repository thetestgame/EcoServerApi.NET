// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Refit;

namespace EcoServerApi.Apis
{
    public interface IDataExportApi
    {
        [Post("/api/v1/exporter/all")]
        Task DataExportPostExportAll([Query] string authtoken, [Query] string authtokentype);

        [Post("/api/v1/exporter/chat")]
        Task DataExportPostExportChat([Query] string authtoken, [Query] string authtokentype);

        [Post("/api/v1/exporter/species")]
        Task DataExportPostExportSpecies([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/exporter/species")]
        Task<string> DataExportGetExportSpecies([Query] string authtoken, [Query] string authtokentype, [Query] string speciesName);

        [Post("/api/v1/exporter/environment")]
        Task DataExportPostExportEnvironment([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/exporter/environment")]
        Task<string> DataExportGetExportEnvironment([Query] string authtoken, [Query] string authtokentype, [Query] string category, [Query] string units, [Query] string column);

        [Post("/api/v1/exporter/actions")]
        Task DataExportPostExportActions([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/exporter/actions")]
        Task<string> DataExportGetExportAction([Query] string authtoken, [Query] string authtokentype, [Query] string actionName);

        [Get("/api/v1/exporter/actionlist")]
        Task<string> DataExportGetActionList([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/exporter/specieslist")]
        Task<string> DataExportGetSpeciesList([Query] string authtoken, [Query] string authtokentype);

        [Get("/api/v1/exporter/environmentlist")]
        Task<string> DataExportGetEnvironmentList([Query] string authtoken, [Query] string authtokentype);
    }
}
