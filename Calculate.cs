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
        public List<ProductReceiptDetails> productReceiptEntries;

        public Calculate(ProductCatalogue catalogue, CustomerBasket customerBasket)
        {
            this.catalogue = catalogue;
            this.customerBasket = customerBasket;
        }

        public void CountBasket()
        {
            this.sortedBasket = new SortedDictionary<string, int>();

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
        }

        public void RetrievePricesForBasket()
        {
            this.productReceiptEntries = new List<ProductReceiptDetails>();

            foreach(var productName in this.sortedBasket)
            {
                if (!catalogue.ProductCataloguDict.ContainsKey(productName.Key))
                {
                    Console.WriteLine("Basket contains something not in the catalogue");
                    throw new Exception();
                }

                var regularPrice = catalogue.ProductCataloguDict[productName.Key];
                var quantity = productName.Value;
                var promotionPlaceHolder = new Promotion();
                var effectivePrice = new MoneyAmount(regularPrice * quantity);

                var interumProductReceiptDetails = new ProductReceiptDetails(
                    new Product(productName.Key, (decimal)regularPrice),
                    quantity, promotionPlaceHolder, effectivePrice);

                productReceiptEntries.Add(interumProductReceiptDetails);
            }
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

        public string ProductReceiptEntriesToString()
        {
            string output = "\n";

            foreach (var item in productReceiptEntries)
            {
                output += item.ToString() + "\n";
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