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
            calculate.RetrievePricesForBasket();
            Assert.AreEqual("\nApple: $1.08 2  $2.16\nBread: $3.54 2  $7.08\nEggs: $8.14 1  $8.14\nMilk: $2.85 1  $2.85\nNutmeg: $4.93 1  $4.93\n", calculate.ProductReceiptEntriesToString());
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
