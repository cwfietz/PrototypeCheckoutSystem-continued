using NUnit.Framework;
using System;
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
