// Copyright (c) Jordan Maxwell. All rights reserved.
// See LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;

namespace EcoServerApi.Models
{
    public class EcoSharedLocalizationLocString
    {
        [JsonPropertyName("NotTranslated")]
        public string NotTranslated { get; set; }

        [JsonPropertyName("Inlinable")]
        public bool Inlinable { get; set; }

        [JsonPropertyName("Length")]
        public int Length { get; set; }
    }
}
