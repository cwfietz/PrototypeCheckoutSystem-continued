using System;
namespace PrototypeCheckoutSystem
{
    public class ProductReceiptDetails
    {
        public Product product;
        public int quantity;
        public Promotion promotion;
        public MoneyAmount effectivePrice;

        public ProductReceiptDetails(
            Product product,
            int quantity,
            Promotion promotion,
            MoneyAmount effectivePrice)
        {
            this.product = product;
            this.quantity = quantity;
            this.promotion = promotion;
            this.effectivePrice = effectivePrice;
        }

        public override string ToString()
        {
            return 
                product.ToString().PadRight(15) + " " +
                quantity.ToString().PadRight(3) + " " +
                promotion.ToString().PadRight(24) + " " +
                effectivePrice.ToString().PadLeft(6);
        }
    }
}
