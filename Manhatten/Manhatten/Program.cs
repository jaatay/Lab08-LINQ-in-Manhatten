using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Manhatten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			LoadJSON();
        }



		public static void LoadJSON()

		{

			using (StreamReader r = new StreamReader("Manhatten.json"))
			{

				string json;
				json = r.ReadToEnd();

				dynamic mainObject = JsonConvert.DeserializeObject(json);

				ManhattenObject newObject = new ManhattenObject { mainObject };
					

			/*foreach (var thing in mainObject)
			{
				Console.WriteLine(thing);
			}*/

			foreach (var item in newObject)
			{
				Console.WriteLine(item);
			}
		}

				//var testObject = from item in newObject select properties.name;

				//Console.WriteLine(newObject.features[0].properties.city);

				

				//newObject.ToString().ForEach(n => Console.WriteLine(n.features));



				/*foreach(object thing in m)
				{
					Console.WriteLine(thing);
				}*/

				


			}

			
		}

		

	}




