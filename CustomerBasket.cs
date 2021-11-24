using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrototypeCheckoutSystem
{
    public class CustomerBasket
    {
        private List<string> CustomerBasketList { get; set; }
        private static string filepath = "../../CustomerBasketFile.json";

        public CustomerBasket(List<string> interumCustomerBasket)
        {
            CustomerBasketList = interumCustomerBasket;
    }

        public static List<string> GeneratateSeedCustomerBasket()
        {
            List<string> customerBasket = new List<string>();
            customerBasket.Add("Eggs");
            customerBasket.Add("Milk");
            customerBasket.Add("Apple");
            customerBasket.Add("Bread");
            customerBasket.Add("Apple");
            customerBasket.Add("Bread");
            customerBasket.Add("Nutmeg");

            return customerBasket;
        }

        public static void WriteCustomerBasketToFile(List<string> customerBasket)
        {
            var output = JsonConvert.SerializeObject(customerBasket, Formatting.Indented);
            File.WriteAllText(filepath, output);
        }

        public static List<string> ReadCustomerBasketFromFile()
        {
            var customerBasketReadFromFile = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(filepath));
            return customerBasketReadFromFile;
        }

        public override string ToString()
        {
            string output = "\n";

            foreach (var item in CustomerBasketList)
            {
                output += item + "\n";
            }

            return output;
        }

    }
}
