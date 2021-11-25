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

        [Test()]
        public void CreateOnSalePromotion()
        {
            var testPromotion = new Promotion
            {
                ProductName = "Nutmeg",
                StartDate = new DateTime(2021, 11, 22),
                EndDate = new DateTime(2021, 12, 07),
                promotionType = TypeOfPromotion.OnSale,
                EffectivePrice = new MoneyAmount(3.18),
                BuyQuantity = 0,
                DiscountedQuantity = 0,
                DiscountProportion = 0.0m,
                Descriptor = "on sale for $3.18 each"
            };
            Assert.AreEqual("{\n  \"promotionType\": 0,\n  \"ProductName\": \"Nutmeg\",\n  \"StartDate\": \"2021-11-22T00:00:00\",\n  \"EndDate\": \"2021-12-07T00:00:00\",\n  \"EffectivePrice\": {\n    \"Symbol\": \"$\",\n    \"Amount\": 3.18\n  },\n  \"BuyQuantity\": 0,\n  \"DiscountedQuantity\": 0,\n  \"DiscountProportion\": 0.0,\n  \"Descriptor\": \"on sale for $3.18 each\"\n}", testPromotion.PromotionToString());
        }

        [Test()]
        public void CreateGroupQuantityPromotion()
        {
            var testPromotion = new Promotion
            {
                ProductName = "Apple",
                StartDate = new DateTime(2021, 11, 23),
                EndDate = new DateTime(2021, 11, 28),
                promotionType = TypeOfPromotion.GroupQuantity,
                EffectivePrice = new MoneyAmount(1.75),
                BuyQuantity = 2,
                DiscountedQuantity = 2,
                DiscountProportion = 0.0m,
                Descriptor = "but 2 for $1.75"
            };
            Assert.AreEqual("{\n  \"promotionType\": 1,\n  \"ProductName\": \"Apple\",\n  \"StartDate\": \"2021-11-23T00:00:00\",\n  \"EndDate\": \"2021-11-28T00:00:00\",\n  \"EffectivePrice\": {\n    \"Symbol\": \"$\",\n    \"Amount\": 1.75\n  },\n  \"BuyQuantity\": 2,\n  \"DiscountedQuantity\": 2,\n  \"DiscountProportion\": 0.0,\n  \"Descriptor\": \"but 2 for $1.75\"\n}", testPromotion.PromotionToString());
        }

        [Test()]
        public void CreateAdditionalDiscountPromotion()
        {
            var testPromotion = new Promotion
            {
                ProductName = "Bread",
                StartDate = new DateTime(2021, 11, 21),
                EndDate = new DateTime(2021, 11, 30),
                promotionType = TypeOfPromotion.GroupQuantity,
                EffectivePrice = new MoneyAmount(),
                BuyQuantity = 1,
                DiscountedQuantity = 1,
                DiscountProportion = 0.3m,
                Descriptor = "buy 1 get 1 for 30% off"
            };
            Assert.AreEqual("{\n  \"promotionType\": 1,\n  \"ProductName\": \"Bread\",\n  \"StartDate\": \"2021-11-21T00:00:00\",\n  \"EndDate\": \"2021-11-30T00:00:00\",\n  \"EffectivePrice\": {\n    \"Symbol\": \"$\",\n    \"Amount\": 0.00\n  },\n  \"BuyQuantity\": 1,\n  \"DiscountedQuantity\": 1,\n  \"DiscountProportion\": 0.3,\n  \"Descriptor\": \"buy 1 get 1 for 30% off\"\n}", testPromotion.PromotionToString());
        }

        [Test()]
        public void CreatePromotionThatIsNotInEffectYet()
        {
            var testPromotion = new Promotion
            {
                ProductName = "Eggs",
                StartDate = new DateTime(2021, 12, 10),
                EndDate = new DateTime(2021, 12, 14),
                promotionType = TypeOfPromotion.OnSale,
                EffectivePrice = new MoneyAmount(7.99),
                BuyQuantity = 0,
                DiscountedQuantity = 0,
                DiscountProportion = 0.0m,
                Descriptor = "on sale for eggnog"
            };
            Assert.AreEqual("{\n  \"promotionType\": 0,\n  \"ProductName\": \"Eggs\",\n  \"StartDate\": \"2021-12-10T00:00:00\",\n  \"EndDate\": \"2021-12-14T00:00:00\",\n  \"EffectivePrice\": {\n    \"Symbol\": \"$\",\n    \"Amount\": 7.99\n  },\n  \"BuyQuantity\": 0,\n  \"DiscountedQuantity\": 0,\n  \"DiscountProportion\": 0.0,\n  \"Descriptor\": \"on sale for eggnog\"\n}", testPromotion.PromotionToString());
        }
    }
}
