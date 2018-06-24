using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace Manhatten
{

	public class RootObject
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("features")]
		public List<Feature> Features { get; set; }

	}
		
}
