namespace PrototypeCheckoutSystem
{
    internal class Calculate
    {
        private ProductCatalogue catalogue;
        private CustomerBasket customerBasket;

        public Calculate(ProductCatalogue catalogue, CustomerBasket customerBasket)
        {
            this.catalogue = catalogue;
            this.customerBasket = customerBasket;
        }
    }
}