// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoWebCoreDataTransferObjectsV1MapV1
    {
        [JsonPropertyName("layerSelected")]
        public string LayerSelected { get; set; }

        [JsonPropertyName("frame")]
        public int Frame { get; set; }

        [JsonPropertyName("timeStart")]
        public double TimeStart { get; set; }

        [JsonPropertyName("timeEnd")]
        public double TimeEnd { get; set; }

        [JsonPropertyName("playSpeed")]
        public double PlaySpeed { get; set; }

        [JsonPropertyName("currentTime")]
        public double CurrentTime { get; set; }

        [JsonPropertyName("flat")]
        public bool Flat { get; set; }

        [JsonPropertyName("pause")]
        public bool Pause { get; set; }

        [JsonPropertyName("camPos")]
        public EcoWebCoreDataTransferObjectsV1Vector3V1 CamPos { get; set; }
    }
}
