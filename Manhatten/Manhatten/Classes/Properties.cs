using System;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;
namespace Manhatten
{
    class Properties
    {
		[JsonProperty("zip")]
		public string Zip { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("address")]
		public string Address { get; set; }

		[JsonProperty("borough")]
		public string Borough { get; set; }

		[JsonProperty("neighborhood")]
		public string Neighborhood { get; set; }

		[JsonProperty("county")]
		public string County { get; set; }
	}
}
