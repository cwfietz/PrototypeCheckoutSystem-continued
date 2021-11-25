using NUnit.Framework;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    [TestFixture()]
    public class ProductCatalogueTests
    {
        [Test()]
        public void CanCreateProductCatalogue()
        {
            var testProductCatalogue = new Dictionary<string, decimal>();
            var catalogue = new ProductCatalogue(testProductCatalogue);
        }

        [Test()]
        public void CanWriteProductCatalogueAsString()
        {
            var testProductCatalogue = new Dictionary<string, decimal>();
            var catalogue = new ProductCatalogue(testProductCatalogue);
            Assert.AreEqual("{}", catalogue.DisplayAsDictionary());
        }

        [Test()]
        public void CanAddAProductToCatalogue()
        {
            var testProduct = new Product("Pineapple", 1.08);
            var testProductCatalogue = new Dictionary<string, decimal>();
            var catalogue = new ProductCatalogue(testProductCatalogue);
            catalogue.Add(testProduct);
            Assert.AreEqual("{\"Pineapple\":1.08}", catalogue.DisplayAsDictionary());
        }

        [Test()]
        public void CanAdd2ProductsToCatalogue()
        {
            var testProduct = new Product("Pineapple", 1.08);
            var testProductCatalogue = new Dictionary<string, decimal>();
            var catalogue = new ProductCatalogue(testProductCatalogue);
            catalogue.Add(testProduct);
            Assert.AreEqual("{\"Pineapple\":1.08}", catalogue.DisplayAsDictionary());
            var testProduct2 = new Product("Pepperoni", 5.73);
            catalogue.Add(testProduct2);
            Assert.AreEqual("{\"Pineapple\":1.08,\"Pepperoni\":5.73}", catalogue.DisplayAsDictionary());
        }

        [Test()]
        public void CanDisplayCatalogueToUsers()
        {
            var testProduct1 = new Product("Pineapple", 1.08);
            var testProduct2 = new Product("Pepperoni", 5.73);

            var testProductCatalogue = new Dictionary<string, decimal>();
            var catalogue = new ProductCatalogue(testProductCatalogue);

            catalogue.Add(testProduct1);
            catalogue.Add(testProduct2);
            Assert.AreEqual("\nPepperoni: $5.73\nPineapple: $1.08\n", catalogue.ToString());
        }

        [Test()]
        public void DisplayLargerCatalogue()
        {
            var testProductCatalogue = new Dictionary<string, decimal>();
            var catalogue = new ProductCatalogue(testProductCatalogue);
            catalogue.Add(new Product("Pepperoni", 5.73));
            catalogue.Add(new Product("Pineapple", 3.99));
            catalogue.Add(new Product("Apple", 1.08));
            catalogue.Add(new Product("Orange", 1.68));
            catalogue.Add(new Product("Banana", 0.79));
            catalogue.Add(new Product("Milk", 2.85));
            catalogue.Add(new Product("Salmon", 20.64));
            catalogue.Add(new Product("Cheese", 7.42));
            Assert.AreEqual("{\"Pepperoni\":5.73,\"Pineapple\":3.99,\"Apple\":1.08,\"Orange\":1.68,\"Banana\":0.79,\"Milk\":2.85,\"Salmon\":20.64,\"Cheese\":7.42}", catalogue.DisplayAsDictionary());
        }
    }
}
