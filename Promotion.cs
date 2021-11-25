using System;
using Newtonsoft.Json;

namespace PrototypeCheckoutSystem
{
    public enum TypeOfPromotion
    {
        OnSale,
        GroupQuantity,
        AdditionalDiscount
    }

    public class Promotion
    {
        public string ProductName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public TypeOfPromotion promotionType;
        public MoneyAmount EffectivePrice { get; set; } // for OnSale or GroupQuantity
        public int BuyQuantity { get; set; } // for GroupQuantity or AdditionalDiscount
        public int DiscountedQuantity { get; set; } // how many are discounted to effectivePrice or discountProportion
        public decimal DiscountProportion { get; set; } // for AdditionalDiscount
        public string Descriptor { get; set; } // note to add to the receipt

        public Promotion()
        {
            ProductName = "";
            StartDate = new DateTime(2021, 11, 24);
            EndDate = new DateTime(2021, 11, 25);
            promotionType = TypeOfPromotion.OnSale;
            EffectivePrice = new MoneyAmount();
            BuyQuantity = 0;
            DiscountedQuantity = 0;
            DiscountProportion = 0.0m;
            Descriptor = "";
        }

        public string PromotionToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public override string ToString()
        {
            return Descriptor;
        }
    }
}
