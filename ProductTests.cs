using NUnit.Framework;

namespace PrototypeCheckoutSystem
{
    [TestFixture()]
    public class ProductTests
    {
        [Test]
        public void CanCreateProduct()
        {
            var testCost = new MoneyAmount();
            Product testProduct = new Product("Apple", testCost);
            Assert.AreEqual("Apple: $0.00", testProduct.ToString());
        }

        [Test]
        public void CanCreateProductWithACostGreaterThanZero()
        {
            var testCost = new MoneyAmount(7.89);
            Product testProduct = new Product("Pizza", testCost);
            Assert.AreEqual("Pizza: $7.89", testProduct.ToString());
        }

        [Test]
        public void CanCreateProductWithoutPreconstructingAmount()
        {
            Product testProduct = new Product("Larger Pizza", 8.90m);
            Assert.AreEqual("Larger Pizza: $8.90", testProduct.ToString());
        }

        [Test]
        public void CanCreateProductUsingDoubleAsAmount()
        {
            Product testProduct = new Product("Yet Larger Pizza", 9.12);
            Assert.AreEqual("Yet Larger Pizza: $9.12", testProduct.ToString());
        }
    }
}
