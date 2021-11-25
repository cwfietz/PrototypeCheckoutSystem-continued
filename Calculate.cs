using System;
using System.Collections.Generic;

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

        public void ProcessBasket()
        {
            CountBasket();
            RetrievePricesForBasket();
            Console.WriteLine(ReceiptToString());
        }

        public void CountBasket()
        {
            this.sortedBasket = new SortedDictionary<string, int>();

            if (customerBasket == null)
            {
                Console.WriteLine("Empty basket");
                throw new Exception();
            }

            foreach (var item in customerBasket.CustomerBasketList)
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

            foreach (var productName in this.sortedBasket)
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

        internal MoneyAmount TotalBasket()
        {
            if (productReceiptEntries.Count <= 0)
            {
                Console.WriteLine("There seems to nothing in the basket.");
                throw new Exception();
            }

            decimal totalPrice = 0;
            foreach (var entry in productReceiptEntries)
            {
                totalPrice += entry.effectivePrice.Amount;
            }
            var finalTotalPrice = new MoneyAmount(totalPrice);
            return finalTotalPrice;
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

            foreach (var entry in productReceiptEntries)
            {
                output += entry.ToString() + "\n";
            }

            return output;
        }

        public string ReceiptToString()
        {
            string output = "\n";
            output += ProductReceiptEntriesToString();
            output += "Total: ";
            output += TotalBasket().ToString();
            output += "\n";
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