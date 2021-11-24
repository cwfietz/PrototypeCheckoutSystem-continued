using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace PrototypeCheckoutSystem
{
    public class ProductCatalogue
    {
        private Dictionary<string, Product> ProductCataloguDict;

        public ProductCatalogue()
        {
            this.ProductCataloguDict = new Dictionary<string, Product>();
        }

        public void Add(Product product)
        {
            ProductCataloguDict.Add(product.Name, product);
        }

        public string DisplayAsDictionary()
        {
            return JsonConvert.SerializeObject(ProductCataloguDict);
        }

        public override string ToString()
        {
            string output="\n";

            foreach(var item in ProductCataloguDict.OrderBy(product => product.Key))
            {
                output += item.Value + "\n";
            }

            return output;
        }
    }
}
