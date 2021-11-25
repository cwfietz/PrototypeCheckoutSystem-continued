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
        public Dictionary<string, Promotion> ActivePromotions;

        public Calculate(ProductCatalogue catalogue, CustomerBasket customerBasket)
        {
            this.catalogue = catalogue;
            this.customerBasket = customerBasket;
        }

        public void ProcessBasket()
        {
            CountBasket();
            GetActivePromotions();
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

        public void GetActivePromotions()
        {
            this.ActivePromotions = new Dictionary<string, Promotion>();

            // The next two lines are substituting for a query for the current date
            // and reading the list of promotions in from a file or database query.
            var now = new DateTime(2021, 11, 25);
            var promoList = PromotionsSource.GenerateSeedPromotionsSource();

            if (promoList.promotionsList.Count <= 0)
            {
                Console.WriteLine("There are no promotions.");
            }

            foreach (var promo in promoList.promotionsList)
            {
                if(promo.StartDate <= now && now <= promo.EndDate)
                {
                    ActivePromotions.Add(promo.ProductName, promo);
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

                var relevantPromotion = AttachPromotions(productName.Key);
                var effectivePrice = ApplyPromotions(regularPrice, quantity, relevantPromotion);

                var interumProductReceiptDetails = new ProductReceiptDetails(
                    new Product(productName.Key, (decimal)regularPrice),
                    quantity, relevantPromotion, effectivePrice);

                productReceiptEntries.Add(interumProductReceiptDetails);
            }
        }

        public Promotion AttachPromotions(string name)
        {
            if (ActivePromotions.ContainsKey(name))
            {
                return ActivePromotions[name];
            }
            return new Promotion();
        }

        // This method ought to make use of the enum and be extensible like the menu and list of menu items
        public MoneyAmount ApplyPromotions(decimal regularPrice, int quantity, Promotion relevantPromotion)
        {
            if(relevantPromotion.promotionType == TypeOfPromotion.OnSale)
            {
                return OnSalePrice(regularPrice, quantity, relevantPromotion);
            }

            if (relevantPromotion.promotionType == TypeOfPromotion.GroupQuantity)
            {
                return GroupQuantityPrice(regularPrice, quantity, relevantPromotion);
            }

            if (relevantPromotion.promotionType == TypeOfPromotion.AdditionalDiscount)
            {
                return AdditionalDiscountPrice(regularPrice, quantity, relevantPromotion);
            }

            return new MoneyAmount(regularPrice * quantity);
        }

        private static MoneyAmount OnSalePrice(decimal regularPrice, int quantity, Promotion relevantPromotion)
        {
            decimal newPrice = 0.00m;

            if (relevantPromotion.ProductName == "")
            {
                newPrice = regularPrice * quantity;
            }
            else
            {
                newPrice = relevantPromotion.EffectivePrice.Amount * quantity;
            }

            return new MoneyAmount(newPrice);
        }

        private static MoneyAmount GroupQuantityPrice(decimal regularPrice, int quantity, Promotion relevantPromotion)
        {
            var number = quantity;
            decimal newPrice = 0.00m;

            while (relevantPromotion.BuyQuantity <= number)
            {
                number = number - relevantPromotion.BuyQuantity;
                newPrice += relevantPromotion.EffectivePrice.Amount;
            }
            newPrice += regularPrice * number;
            return new MoneyAmount(newPrice);
        }

        private static MoneyAmount AdditionalDiscountPrice(decimal regularPrice, int quantity, Promotion relevantPromotion)
        {
            var number = quantity;
            decimal newPrice = 0.00m;

            while ((relevantPromotion.BuyQuantity + relevantPromotion.DiscountedQuantity) <= number)
            {
                number = number - relevantPromotion.BuyQuantity;
                newPrice += regularPrice * relevantPromotion.BuyQuantity;
                number = number - relevantPromotion.DiscountedQuantity;
                newPrice += (regularPrice - 
                    Math.Round((regularPrice * relevantPromotion.DiscountProportion), 2)
                     * relevantPromotion.DiscountedQuantity);
            }
            newPrice += regularPrice * number;
            return new MoneyAmount(newPrice);
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
            output += "\n";
            output += ("Total: " +  TotalBasket().ToString()).PadLeft(51);
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