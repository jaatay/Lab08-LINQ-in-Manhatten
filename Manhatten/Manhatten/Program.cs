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
			Console.WriteLine(LoadJSON());
        }


		public static string LoadJSON()
		{
			string json;
			using (StreamReader r = new StreamReader("Manhatten.json"))
			{
				json = r.ReadToEnd();

			}

			return json;
		}
	}

	
	
}
