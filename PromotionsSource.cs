using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrototypeCheckoutSystem
{
    public class PromotionsSource
    {
        public List<Promotion> promotionsList;

        public PromotionsSource()
        {
            promotionsList = new List<Promotion>();
        }

        public void Add(Promotion promotion)
        {
            promotionsList.Add(promotion);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public static PromotionsSource GenerateSeedPromotionsSource()
        {
            var promotionsList = new PromotionsSource();

            var NutmegPromo = new Promotion
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
            promotionsList.Add(NutmegPromo);

            var ApplePromo = new Promotion
            {
                ProductName = "Apple",
                StartDate = new DateTime(2021, 11, 23),
                EndDate = new DateTime(2021, 11, 28),
                promotionType = TypeOfPromotion.GroupQuantity,
                EffectivePrice = new MoneyAmount(1.75),
                BuyQuantity = 2,
                DiscountedQuantity = 2,
                DiscountProportion = 0.0m,
                Descriptor = "buy 2 for $1.75"
            };
            promotionsList.Add(ApplePromo);

            var BreadPromo = new Promotion
            {
                ProductName = "Bread",
                StartDate = new DateTime(2021, 11, 21),
                EndDate = new DateTime(2021, 11, 30),
                promotionType = TypeOfPromotion.AdditionalDiscount,
                EffectivePrice = new MoneyAmount(),
                BuyQuantity = 1,
                DiscountedQuantity = 1,
                DiscountProportion = 0.3m,
                Descriptor = "buy 1 get 1 for 30% off"
            };
            promotionsList.Add(BreadPromo);

            var EggsPromo = new Promotion
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
            promotionsList.Add(EggsPromo);

            return promotionsList;
        }

    }
}
