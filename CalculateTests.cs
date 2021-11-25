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
            Console.WriteLine(calculate.SortedBasketToString());
            Assert.AreEqual("\nApple: 2\nBread: 2\nEggs: 1\nMilk: 1\nNutmeg: 1\n", calculate.SortedBasketToString());
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
