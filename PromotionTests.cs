using NUnit.Framework;
namespace PrototypeCheckoutSystem
{
    [TestFixture()]
    public class PromotionTests
    {
        [Test()]
        public void CreatePromotion()
        {
            var testPromotion = new Promotion();
            Assert.AreEqual("", testPromotion.ToString());
        }
    }
}
