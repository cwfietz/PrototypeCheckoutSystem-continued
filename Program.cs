using System;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Menu.PopulateMenuItems();
            //Menu.MainMenu();

            Dictionary<string, decimal> products = ProductCatalogue.GenerateSeedCatalogue();
            ProductCatalogue.WriteCatalogueToFile(products);
            var catalogue = new ProductCatalogue();
            Console.WriteLine(catalogue.ToString());
            Console.WriteLine(catalogue.DisplayAsDictionary());

            System.Environment.Exit(0);
        }
    }
}
