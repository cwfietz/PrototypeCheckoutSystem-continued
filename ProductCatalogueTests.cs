using NUnit.Framework;
using System;
namespace PrototypeCheckoutSystem
{
    [TestFixture()]
    public class ProductCatalogueTests
    {
        [Test()]
        public void CanCreateProductCatalogue()
        {
            var testProductCatalogue = new ProductCatalogue();
        }

        [Test()]
        public void CanWriteProductCatalogueAsString()
        {
            var testProductCatalogue = new ProductCatalogue();
            Assert.AreEqual("{}", testProductCatalogue.ToString());
        }

        [Test()]
        public void CanAddAProductToCatalogue()
        {
            var testProduct = new Product("Pineapple", 1.08);
            var testProductCatalogue = new ProductCatalogue();
            testProductCatalogue.Add(testProduct);
            Assert.AreEqual("{\"Pineapple\":{\"RegularPrice\":{\"Symbol\":\"$\",\"Amount\":1.08},\"Name\":\"Pineapple\"}}", testProductCatalogue.ToString());
        }
    }
}
