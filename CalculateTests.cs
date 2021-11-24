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
            var interumCatalogue = ProductCatalogue.GenerateSeedCatalogue();
            var catalogue = new ProductCatalogue(interumCatalogue);

            var interumCustomerBasket = CustomerBasket.GeneratateSeedCustomerBasket();
            var customerBasket = new CustomerBasket(interumCustomerBasket);
            var result = new Calculate(catalogue, customerBasket);
        }
    }
}
