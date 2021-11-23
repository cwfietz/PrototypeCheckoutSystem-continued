using System;
namespace PrototypeCheckoutSystem
{
    public class MoneyAmount
    {
        public string Symbol { get; set; }
        public decimal Amount { get; set; }

        public MoneyAmount(string symbol, decimal amount)
        {
            this.Symbol = symbol;
            this.Amount = amount;
        }

        public MoneyAmount(decimal amount) : this("$", amount)
        {
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
