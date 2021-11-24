using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Menu.PopulateMenuItems();
            //Menu.MainMenu();

            Dictionary<string, double> catalogue = new Dictionary<string, double>();
            catalogue.Add("Pineapple", 3.99);
            catalogue.Add("Pepperoni", 5.73);
            catalogue.Add("Apple", 1.08);
            catalogue.Add("Orange", 1.68);
            catalogue.Add("Banana", 0.79);
            catalogue.Add("Milk", 2.85);
            catalogue.Add("Salmon", 20.64);
            catalogue.Add("Cheese", 7.42);
            catalogue.Add("Bread", 3.54);
            catalogue.Add("Olive oil", 12.58);
            catalogue.Add("Chocolate bar", 2.15);
            catalogue.Add("Fennel seeds", 3.45);
            catalogue.Add("Pepper", 4.05);
            catalogue.Add("Cantaloupe", 3.79);
            catalogue.Add("Eggs", 8.14);
            catalogue.Add("Celery", 2.75);
            catalogue.Add("Lettus", 6.00);
            catalogue.Add("Nutmeg", 4.93);
            Console.WriteLine(catalogue.ToString());

            string filepath = "../../CatalogueFile.json";

            var output = JsonConvert.SerializeObject(catalogue, Formatting.Indented);
            Console.WriteLine(output);
            File.WriteAllText(filepath, output);

            var catalogueReadFromFile = JsonConvert.DeserializeObject<Dictionary<string, double>>(File.ReadAllText(filepath));
            Console.WriteLine(catalogueReadFromFile.ToString());

            string items = "\n";
            foreach (var item in catalogueReadFromFile.OrderBy(product => product.Key))
            {
                items += item + "\n";
            }
            Console.WriteLine(items);

            System.Environment.Exit(0);
        }
    }
}
