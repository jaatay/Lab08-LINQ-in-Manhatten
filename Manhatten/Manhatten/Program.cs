using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;


namespace Manhatten
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			LoadList();
		}

		public static void LoadList()

		{

			using (StreamReader r = new StreamReader("Manhatten.json"))
			{

				string json;
				json = r.ReadToEnd();

				dynamic mainObject = JsonConvert.DeserializeObject(json);

				ManhattenObject newObject = new ManhattenObject
				{
					Type = mainObject.type,
					Features = mainObject.features
				};

				Geometry testObject = new Geometry
				{
					Type = mainObject.features[0].type,
					Coordinates = mainObject.features[0].geometry
				};

				
				Console.WriteLine(newObject.Features);

				Console.WriteLine(newObject);

				Console.WriteLine(testObject.Coordinates);

			}

		}
	}
}



			
		

		

	




