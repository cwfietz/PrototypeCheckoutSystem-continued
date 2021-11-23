namespace PrototypeCheckoutSystem
{
    public class Product
    {
        public string Name { get; set; }
        public MoneyAmount RegularPrice;

        public Product(string Name, MoneyAmount Amount)
        {
            this.Name = Name;
            this.RegularPrice = Amount;
        }

        public Product(string Name, decimal Amount) : this(Name, new MoneyAmount(Amount))
        {
        }

        public Product(string Name, double Amount) : this(Name, new MoneyAmount(Amount))
        {
        }

        public override string ToString()
        {
            return Name + ": " + RegularPrice;
        }
    }
}
