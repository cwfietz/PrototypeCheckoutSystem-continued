using System;
using System.Collections.Generic;

namespace PrototypeCheckoutSystem
{
    class Menu
    {
        private static List<MenuItem> MenuItems;

        public static void PopulateMenuItems()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem {Description = "Show product and prices list", Execute = ShowProductAndPricesList},
                new MenuItem {Description = "Show promotions", Execute = ShowPromotions},
                new MenuItem {Description = "Show customer basket", Execute = ShowCustomerBasket},
                new MenuItem {Description = "Calculate customer basket", Execute = CalculateCustomerBasket},
                new MenuItem {Description = "Exit", Execute = Exit},
            };
        }

        public static void MainMenu()
        {
            ClearAndShowHeading("Main Menu");

            Console.CursorVisible = false;
            while (true)
            {
                int selectedMenuItem = DrawMainMenu();
                MenuItems[selectedMenuItem - 1].Execute();
            }
        }

        public static int DrawMainMenu()
        {
            for (int index = 0; index < MenuItems.Count; index++)
            {
                Console.WriteLine($" {index + 1}. {MenuItems[index].Description}");
            }

            int cursorTop = Console.CursorTop + 1;
            int userInput = 0;

            do
            {
                Console.SetCursorPosition(0, cursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, cursorTop);
                Console.Write($"Enter a choice (1 - {MenuItems.Count}): ");
            } while (!int.TryParse(Console.ReadLine(), out userInput) ||
                     userInput < 1 || MenuItems.Count < userInput);

            return userInput;
        }

        private static void ClearAndShowHeading(string heading)
        {
            Console.Clear();
            Console.WriteLine(heading);
            Console.WriteLine(new string('-', heading?.Length ?? 0));
        }

        private static void ReturnToMainMenu()
        {
            Console.WriteLine("Press a key to continue to the main menu...");
            Console.CursorVisible = false;
            Console.ReadKey();
            MainMenu();
        }

        private static void ShowProductAndPricesList()
        {
            ClearAndShowHeading("Show product and prices list");

            //var productSeedCatalogue = ProductCatalogue.GenerateSeedCatalogue();
            //ProductCatalogue.WriteCatalogueToFile(productSeedCatalogue);

            var interumCatalogue = ProductCatalogue.ReadCatalogueFromFile();
            var catalogue = new ProductCatalogue(interumCatalogue);
            Console.WriteLine(catalogue.ToString());
            ReturnToMainMenu();
        }

        private static void ShowPromotions()
        {
            ClearAndShowHeading("Show promotions");
            ReturnToMainMenu();
        }

        private static void ShowCustomerBasket()
        {
            ClearAndShowHeading("Show customer basket");

            //var customerSeedBasket = CustomerBasket.GeneratateSeedCustomerBasket();
            //CustomerBasket.WriteCustomerBasketToFile(customerSeedBasket);

            var interumBasket = CustomerBasket.ReadCustomerBasketFromFile();
            var customerBasket = new CustomerBasket(interumBasket);
            Console.WriteLine(customerBasket.ToString());
            ReturnToMainMenu();
        }

        private static void CalculateCustomerBasket()
        {
            ClearAndShowHeading("Calculate customer basket");

            var interumCatalogue = ProductCatalogue.ReadCatalogueFromFile();
            var catalogue = new ProductCatalogue(interumCatalogue);

            var interumBasket = CustomerBasket.ReadCustomerBasketFromFile();
            var customerBasket = new CustomerBasket(interumBasket);

            var calculation = new Calculate(catalogue, customerBasket);

            ReturnToMainMenu();
        }

        private static void Exit()
        {
            ClearAndShowHeading("Exit");
            Console.WriteLine("Exiting program.");
            System.Environment.Exit(0);  // or Environment.Exit(0);
        }
    }
}