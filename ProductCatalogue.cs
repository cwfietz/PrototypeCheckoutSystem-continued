using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrototypeCheckoutSystem
{
    public class ProductCatalogue
    {
        public Dictionary<string, decimal> ProductCataloguDict;
        private static string filepath = "../../CatalogueFile.json";
        private static string MoneySymbol = "$";

        public ProductCatalogue(Dictionary<string, decimal> productCatalogue)
        {
            ProductCataloguDict = productCatalogue;
        }

        public static Dictionary<string, decimal> GenerateSeedCatalogue()
        {
            Dictionary<string, decimal> catalogue = new Dictionary<string, decimal>();
            catalogue.Add("Pineapple", 3.99m);
            catalogue.Add("Pepperoni", 5.73m);
            catalogue.Add("Apple", 1.08m);
            catalogue.Add("Orange", 1.68m);
            catalogue.Add("Banana", 0.79m);
            catalogue.Add("Milk", 2.85m);
            catalogue.Add("Salmon", 20.64m);
            catalogue.Add("Cheese", 7.42m);
            catalogue.Add("Bread", 3.54m);
            catalogue.Add("Olive oil", 12.58m);
            catalogue.Add("Chocolate bar", 2.15m);
            catalogue.Add("Fennel seeds", 3.45m);
            catalogue.Add("Pepper", 4.05m);
            catalogue.Add("Cantaloupe", 3.79m);
            catalogue.Add("Eggs", 8.14m);
            catalogue.Add("Celery", 2.75m);
            catalogue.Add("Lettus", 6.00m);
            catalogue.Add("Nutmeg", 4.93m);
            return catalogue;
        }

        public static void WriteCatalogueToFile(Dictionary<string, decimal> catalogue)
        {
            var output = JsonConvert.SerializeObject(catalogue, Formatting.Indented);
            File.WriteAllText(filepath, output);
        }

        public static Dictionary<string, decimal> ReadCatalogueFromFile()
        {
            var catalogueReadFromFile = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(File.ReadAllText(filepath));
            return catalogueReadFromFile;
        }

        internal void Add(Product product)
        {
            ProductCataloguDict.Add(product.Name, (decimal) product.RegularPrice);

        }

        public string DisplayAsDictionary()
        {
            return JsonConvert.SerializeObject(ProductCataloguDict);
        }

        public override string ToString()
        {
            string output = "\n";

            foreach (var item in ProductCataloguDict.OrderBy(product => product.Key))
            {
                output += item.Key + ": " + MoneySymbol + item.Value + "\n";
            }

            return output;
        }
    }
}
