using System;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    class Menu
    {
        static int indexOfMenu = 0;

        public static void MainMenu()
        {
            Console.Clear();

            List<string> menuItems = new List<string>()
            {
                "Edit product and prices list",
                "Edit promitions",
                "Edit customer basket",
                "Calculate customer basket",
                "Exit"
            };

            Console.CursorVisible = false;
            bool keepLooping = true;
            while (keepLooping)
            {
                string selectedMenuItem = drawMainMenu(menuItems);
                if (selectedMenuItem == "Edit product and prices list")
                {
                    Console.WriteLine("Edit product and prices list.");
                    ReturnToMainMenu();
                }
                else if (selectedMenuItem == "Edit promitions")
                {
                    Console.WriteLine("Edit promitions.");
                    ReturnToMainMenu();
                }
                else if (selectedMenuItem == "Edit customer basket")
                {
                    Console.WriteLine("Edit customer basket.");
                    ReturnToMainMenu();
                }
                else if (selectedMenuItem == "Calculate customer basket")
                {
                    Console.WriteLine("Calculate customer basket.");
                    ReturnToMainMenu();
                }
                else if (selectedMenuItem == "Exit")
                {
                    Console.WriteLine("Exiting program.");
                    keepLooping = false;
                    //System.Environment.Exit(0);  // Environment.Exit(0); // Or  System.Environment.Exit(0);
                }
            }
        }

        private static void ReturnToMainMenu()
        {
            Console.WriteLine("Press key to continue to the main menu.");
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.Clear();
        }

        public static string drawMainMenu(List<string> items)
        {
            for (int index = 0; index < items.Count; index++)
            {
                if (index == indexOfMenu)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(items[index]);
                }
                else
                {
                    Console.WriteLine(items[index]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();
            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (indexOfMenu == items.Count - 1) { }
                else { indexOfMenu++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (indexOfMenu <= 0) { }
                else { indexOfMenu--; }
            }
            else if (ckey.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
            }
            else if (ckey.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[indexOfMenu];
            }
            else
            {
                Console.Clear();
                return "";
            }

            Console.Clear();
            return "";
        }
    }
}