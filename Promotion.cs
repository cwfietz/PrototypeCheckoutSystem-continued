using System;
namespace PrototypeCheckoutSystem
{
    public class Promotion
    {
        public string descriptor;

        public Promotion()
        {
            this.descriptor = "";
        }

        public override string ToString()
        {
            return descriptor.ToString();
        }
    }
}
