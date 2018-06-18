using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace Manhatten
{

	public class ManhattenObject
	{
		[JsonProperty]
		public string Type { get; set; }

		[JsonProperty]
		public IList Features { get; set; }


	}
		
}
