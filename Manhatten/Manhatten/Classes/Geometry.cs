using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace Manhatten
{
    class Geometry
    {
			[JsonProperty("type")]
			public string Type { get; set; }

			[JsonProperty("coordinates")]
			public List<double> Coordinates { get; set; }


		

	}
}
