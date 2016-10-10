﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UIOMatic.Models
{
    public class UIOMaticEditablePropertyInfo : UIOMaticPropertyInfo
    {
        [JsonProperty("tab")]
        public string Tab { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("view")]
        public string View { get; set; }

        [JsonProperty("config")]
        public JObject Config { get; set; }

        public UIOMaticEditablePropertyInfo()
        {
            Tab = "General";
        }
    }

    public class UIOMaticViewablePropertyInfo : UIOMaticPropertyInfo
    {
        [JsonProperty("view")]
        public string View { get; set; }

        [JsonProperty("config")]
        public JObject Config { get; set; }
    }

    public class UIOMaticPropertyInfo
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}