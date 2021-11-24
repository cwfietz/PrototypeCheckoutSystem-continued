using System;
using System.Collections.Generic;
using PrototypeCheckoutSystem;

namespace PrototypeCheckoutSystem
{
    public class Calculate
    {
        public ProductCatalogue catalogue;
        public CustomerBasket customerBasket;
        public SortedBasket sortedBasket;

        public Calculate(ProductCatalogue catalogue, CustomerBasket customerBasket)
        {
            this.catalogue = catalogue;
            this.customerBasket = customerBasket;
        }

        internal void CountBasket()
        {
            var sortedBasket = BuildSortedBasket(customerBasket, sortedBasket);


            //throw new NotImplementedException();
        }
    }

    public class BuildSortedBasket
    {
        public BuildSortedBasket(CustomerBasket customerBasket, SortedBasket sortedBasket)
        {
            if (customerBasket != null)
            {
                foreach (var item in customerBasket)
                {
                    sortedBasket.Add()
            }
            }

            return newBasket;
        }

    }

    internal class SortedBasket
    {
        SortedDictionary<string, List<PricesAndQuantities> sortedBasket;
        
        public SortedBasket()
        {

        }

        public void Add(PricesAndQuantities pricesAndQuantities)
        {
            sortedBasket.Add()
        }
    }

    internal class PricesAndQuantities {
    private Product product;
    private int number;
    private string promotion;
    private decimal effectivePrice;
}



}