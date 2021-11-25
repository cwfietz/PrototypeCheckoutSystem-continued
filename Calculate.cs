using System;
using System.Collections.Generic;
using PrototypeCheckoutSystem;

namespace PrototypeCheckoutSystem
{
    public class Calculate
    {
        public ProductCatalogue catalogue;
        public CustomerBasket customerBasket;
        public SortedDictionary<string, int> sortedBasket;


        public Calculate(ProductCatalogue catalogue, CustomerBasket customerBasket)
        {
            this.catalogue = catalogue;
            this.customerBasket = customerBasket;
        }

        public void CountBasket()
        {
            var sortedBasket = new SortedDictionary<string, int>();
            if (customerBasket == null)
            {
                Console.WriteLine("Empty basket");
                throw new Exception();
            }

            foreach (var item in customerBasket.CustomerBasketList )
            {
                if (sortedBasket.ContainsKey(item))
                {
                    int value = 0;
                    sortedBasket.TryGetValue(item, out value);
                    ++value;
                    sortedBasket[item] = value;
                }
                else
                {
                    sortedBasket.Add(item, 1);
                }
            }

            this.sortedBasket = sortedBasket;
        }

        public string SortedBasketToString()
        {
            string output = "\n";

            foreach (var item in sortedBasket)
            {
                output += item.Key + ": " + item.Value + "\n";
            }

            return output;
        }

        public override string ToString()
        {
            string output = "\n";

            foreach (var item in sortedBasket)
            {
                output += item.Key + ": " + item.Value + "\n";
            }

            return output;
        }
    }
}