using System;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Menu.PopulateMenuItems();
            //Menu.MainMenu();

            var Product1 = new Product("Orange", new MoneyAmount(0.89));
            var Product2 = new Product("Banana", new MoneyAmount(0.79));
            var Product3 = new Product("Kiwi", 0.65);


            Console.WriteLine(Product1);
            Console.WriteLine(Product2);
            Console.WriteLine(Product3);

            System.Environment.Exit(0);
        }
    }
}
