using System;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var mainMenu = new Menu();
            Menu.MainMenu();
            System.Environment.Exit(0);
        }
    }
}
