using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace Manhatten
{
    class Feature
    {
		[JsonProperty("type")]
		public string Type { get; set; }
		[JsonProperty("geometry")]
		public Geometry Geometry { get; set; }
		[JsonProperty("properties")]
		public Properties Properties { get; set; }
    }
}
