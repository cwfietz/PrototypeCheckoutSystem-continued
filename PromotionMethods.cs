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

    public class PromotionMethods
    {
        public static Dictionary<TypeOfPromotion, PromotionMethodItem> promotionMethods;

        public static void PopulatePromotionMethods()
        {
            promotionMethods = new Dictionary<TypeOfPromotion, PromotionMethodItem>
            {
                { TypeOfPromotion.OnSale, new PromotionMethodItem { Execute = OnSalePrice } }
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