using NUnit.Framework;
namespace PrototypeCheckoutSystem
{
    [TestFixture()]
    public class ProductReceiptDetailsTests
    {
        [Test()]
        public void CanAddProductReceiptDetails()
        {
            var name = "nameOfProduct";
            var regularPrice = 1.23;
            var product = new Product(name, regularPrice);
            int quantity = 3;
            Promotion promotion = new Promotion();
            var effectivePrice = new MoneyAmount(regularPrice * quantity);
            var testProductReceiptDetails = new ProductReceiptDetails(
                product,
                quantity,
                promotion,
                effectivePrice
            );
            Assert.AreEqual("nameOfProduct: $1.23 3                             $3.69", testProductReceiptDetails.ToString());
        }
    }
}
