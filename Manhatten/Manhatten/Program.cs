﻿using Newtonsoft.Json.Linq;
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

				RootObject mainObject = JsonConvert.DeserializeObject<RootObject>(json);

				var neighborhoods = from i in mainObject.Features
									select i.Properties.Neighborhood;

				Console.WriteLine("--------All neighborhoods--------");
				foreach (var item in neighborhoods)
				{
				
					Console.WriteLine(item);
				}

				var namedNeighborhoods = from i in neighborhoods
										 where i != ""
										 select i;

				Console.WriteLine("-------All named neighborhoods-------");
				foreach (var item in namedNeighborhoods)
				{
					
					Console.WriteLine(item);
				}

				var uniqueNeighborhoods = from x in namedNeighborhoods
										  group x by x into RandomlyNamedGroup
										  orderby RandomlyNamedGroup.Key
										  select RandomlyNamedGroup.Key;

				Console.WriteLine("-------All unique neighborhoods-------");
				
				foreach(var item in uniqueNeighborhoods)
					Console.WriteLine(item);


				var oneLinqToRuleThemAll = from i in mainObject.Features
										   where i.Properties.Neighborhood != ""
										   group i.Properties.Neighborhood by i.Properties.Neighborhood
											into allTheThings
										   select allTheThings.Key;

				Console.WriteLine("---------------All In One Query -----------------");
				foreach(var item in oneLinqToRuleThemAll)
				{
					Console.WriteLine(item);
				}


			}

		}
	}
}



			
		

		

	




