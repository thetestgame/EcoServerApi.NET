// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebServerWebModelsAdminReturnModel
    {
        [JsonPropertyName("Action")]
        public string Action { get; set; }

        [JsonPropertyName("Message")]
        public string Message { get; set; }
    }
}
