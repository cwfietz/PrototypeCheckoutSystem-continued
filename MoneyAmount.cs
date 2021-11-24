using System;
namespace PrototypeCheckoutSystem
{
    public class MoneyAmount
    {
        public string Symbol = "$";
        public decimal Amount { get; set; }

        public MoneyAmount(decimal amount)
        {
            this.Amount = amount;
        }

        public MoneyAmount(double amount) : this(Convert.ToDecimal(amount))
        {
        }

        public MoneyAmount() : this(0.00m)
        {
        }

        public override string ToString()
        {
            return Symbol + Amount;
        }
    }
}
