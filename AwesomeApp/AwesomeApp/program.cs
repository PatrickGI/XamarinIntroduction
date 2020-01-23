using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace AwesomeApp
{
    class program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("C:\\Users\\patpa\\source\\repos\\AwesomeApp\\products.json");

            var results = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);

            foreach (var item in results)
            {
                Console.Out.WriteLine(item.desc);
            }
        }
    }
}
