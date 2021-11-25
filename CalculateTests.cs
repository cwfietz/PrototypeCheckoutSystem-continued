using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    [TestFixture()]
    public class CalculateTests
    {
        [Test()]
        public void CanCreateCalculateClass()
        {
            var calculate = GetSeedCalculate();
        }

        [Test()]
        public void CanReadAndCountCustomerBasket()
        {
            var calculate = GetSeedCalculate();
            calculate.CountBasket();
            Assert.AreEqual("\nApple: 2\nBread: 2\nEggs: 1\nMilk: 1\nNutmeg: 1\n", calculate.SortedBasketToString());
        }

        [Test()]
        public void CanRetrievePricesForBasket()
        {
            var calculate = GetSeedCalculate();
            calculate.CountBasket();
            calculate.GetActivePromotions();
            calculate.RetrievePricesForBasket();
            Assert.AreEqual("\nApple: $1.08 2 buy 2 for $1.75 $1.75\nBread: $3.54 2 buy 1 get 1 for 30% off $6.02\nEggs: $8.14 1  $8.14\nMilk: $2.85 1  $2.85\nNutmeg: $4.93 1 on sale for $3.18 each $3.18\n", calculate.ProductReceiptEntriesToString());
        }

        [Test()]
        public void CanRetrieveTotalPriceForBasketWithNoPromotions()
        {
            var calculate = GetSeedCalculate();
            calculate.CountBasket();
            calculate.GetActivePromotions();
            calculate.RetrievePricesForBasket();
            Assert.AreEqual("$21.94", calculate.TotalBasket().ToString());
        }

        [Test()]
        public void CanPrintReceipt()
        {
            var calculate = GetSeedCalculate();
            calculate.CountBasket();
            calculate.GetActivePromotions();
            calculate.RetrievePricesForBasket();
            Assert.AreEqual("\n\nApple: $1.08 2 buy 2 for $1.75 $1.75\nBread: $3.54 2 buy 1 get 1 for 30% off $6.02\nEggs: $8.14 1  $8.14\nMilk: $2.85 1  $2.85\nNutmeg: $4.93 1 on sale for $3.18 each $3.18\nTotal: $21.94\n", calculate.ReceiptToString());
        }

        private Calculate GetSeedCalculate()
        {
            var interumCatalogue = ProductCatalogue.GenerateSeedCatalogue();
            var catalogue = new ProductCatalogue(interumCatalogue);

            var interumCustomerBasket = CustomerBasket.GeneratateSeedCustomerBasket();
            var customerBasket = new CustomerBasket(interumCustomerBasket);
            var result = new Calculate(catalogue, customerBasket);
            return result;
        }


    }
}
