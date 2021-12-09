using System;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    public enum TypeOfPromotion
    {
        OnSale,
        GroupQuantity,
        AdditionalDiscount
    }

    public class PopulatePromotionMethods
    {
        public Dictionary<TypeOfPromotion, Action> promotionMethods;

        public static PopulatePromotionMethods()
        {
            promotionMethods = new Dictionary<TypeOfPromotion, Action>
            {
                { TypeOfPromotion.OnSale, (Action)OnSalePrice }
            };
        }

        private static MoneyAmount OnSalePrice(decimal regularPrice, int quantity, Promotion relevantPromotion)
        {
            decimal newPrice = 0.00m;

            if (relevantPromotion.ProductName == "")
            {
                newPrice = regularPrice * quantity;
            }
            else
            {
                newPrice = relevantPromotion.EffectivePrice.Amount * quantity;
            }

            return new MoneyAmount(newPrice);
        }
    }
}