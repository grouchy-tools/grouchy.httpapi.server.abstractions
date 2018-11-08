﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Grouchy.HttpApi.Server.Abstractions.Model
{
   public class Dependency
   {
      public string Name { get; set; }

      [JsonConverter(typeof(StringEnumConverter))]
      public Availability Availability { get; set; }

      [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
      public string Version { get; set; }
      
      [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
      public double? ClosedPct { get; set; }
   }
}