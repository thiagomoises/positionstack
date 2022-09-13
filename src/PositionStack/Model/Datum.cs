﻿using Newtonsoft.Json;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace PositionStack.Model
{
    public partial class Datum
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("number")]
        public string? Number { get; set; }

        [JsonProperty("postal_code")]
        public string? PostalCode { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("region")]
        public string? Region { get; set; }

        [JsonProperty("region_code")]
        public string? RegionCode { get; set; }

        [JsonProperty("county")]
        public string? County { get; set; }

        [JsonProperty("locality")]
        public string? Locality { get; set; }

        [JsonProperty("administrative_area")]
        public string? AdministrativeArea { get; set; }

        [JsonProperty("neighbourhood")]
        public string? Neighbourhood { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("country_code")]
        public string? CountryCode { get; set; }

        [JsonProperty("continent")]
        public string? Continent { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }
    }
}
