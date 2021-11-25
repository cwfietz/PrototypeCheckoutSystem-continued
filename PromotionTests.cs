using System;
using NUnit.Framework;
namespace PrototypeCheckoutSystem
{
    [TestFixture()]
    public class PromotionTests
    {
        [Test()]
        public void CreateEmptyPromotion()
        {
            var testPromotion = new Promotion();
            Assert.AreEqual("{\n  \"promotionType\": 0,\n  \"ProductName\": \"\",\n  \"StartDate\": \"2021-11-24T00:00:00\",\n  \"EndDate\": \"2021-11-25T00:00:00\",\n  \"EffectivePrice\": {\n    \"Symbol\": \"$\",\n    \"Amount\": 0.00\n  },\n  \"BuyQuantity\": 0,\n  \"DiscountedQuantity\": 0,\n  \"DiscountProportion\": 0.0,\n  \"Descriptor\": \"\"\n}", testPromotion.PromotionToString());
        }
    }
}
