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
		
			[JsonProperty]
			public string Type { get; set; }

			[JsonProperty]
			public IList Coordinates { get; set; }


		

	}
}
