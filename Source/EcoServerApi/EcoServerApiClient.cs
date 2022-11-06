// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using EcoServerApi.Apis;
using Refit;
using System.Net.Http;

namespace EcoServerApi
{
    public class EcoServerApiClient
    {
        public EcoServerApiClient(HttpClient http)
        {
            AdminApi = RestService.For<IAdminApi>(http);
            ChatApi = RestService.For<IChatApi>(http);
            CommandApi = RestService.For<ICommandApi>(http);
            DataExportApi = RestService.For<IDataExportApi>(http);
            ElectionApi = RestService.For<IElectionApi>(http);
            LawApi = RestService.For<ILawApi>(http);
            LogApi = RestService.For<ILogApi>(http);
            MapApi = RestService.For<IMapApi>(http);
            PluginsApi = RestService.For<IPluginsApi>(http);
            ProfilingResultsApi = RestService.For<IProfilingResultsApi>(http);
            RootApi = RestService.For<IRootApi>(http);
            StatsApi = RestService.For<IStatsApi>(http);
            UsersApi = RestService.For<IUsersApi>(http);
            WorldLayerApi = RestService.For<IWorldLayerApi>(http);
        }

        public IAdminApi AdminApi { get; }
        public IChatApi ChatApi { get; }
        public ICommandApi CommandApi { get; }
        public IDataExportApi DataExportApi { get; }
        public IElectionApi ElectionApi { get; }
        public ILawApi LawApi { get; }
        public ILogApi LogApi { get; }
        public IMapApi MapApi { get; }
        public IPluginsApi PluginsApi { get; }
        public IProfilingResultsApi ProfilingResultsApi { get; }
        public IRootApi RootApi { get; }
        public IStatsApi StatsApi { get; }
        public IUsersApi UsersApi { get; }
        public IWorldLayerApi WorldLayerApi { get; }
    }
}
