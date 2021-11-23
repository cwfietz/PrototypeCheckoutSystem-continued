using System;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MoneyAmount price = new MoneyAmount
            {
                Symbol = "$",
                Amount = 2.34m
            };
            Console.WriteLine(price);
            Console.WriteLine("{0}{1}", price.Symbol, price.Amount);

            MoneyAmount price2 = new MoneyAmount
            {
                Symbol = "$",
            };
            Console.WriteLine(price2);
            Console.WriteLine("{0}{1}", price2.Symbol, price2.Amount);

            MoneyAmount price3 = new MoneyAmount
            {
                Amount = 2.34m
            };
            Console.WriteLine(price3);
            Console.WriteLine("{0}{1}", price3.Symbol, price3.Amount);

            MoneyAmount price4 = new MoneyAmount(5.67m);
            Console.WriteLine(price4);
            Console.WriteLine("{0}{1}", price4.Symbol, price4.Amount);

            MoneyAmount price5 = new MoneyAmount(6.78);
            Console.WriteLine(price5);
            Console.WriteLine("{0}{1}", price5.Symbol, price5.Amount);

            MoneyAmount price6 = new MoneyAmount();
            Console.WriteLine(price6);
            Console.WriteLine("{0}{1}", price6.Symbol, price6.Amount);

            //Menu.PopulateMenuItems();
            //Menu.MainMenu();
        }
    }
}
