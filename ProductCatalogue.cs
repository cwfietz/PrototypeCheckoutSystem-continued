using System;
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

        public override string ToString()
        {
            return JsonConvert.SerializeObject(ProductCataloguDict);
        }
    }
}
