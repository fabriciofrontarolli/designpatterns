using System;

namespace TemplateMethod
{
    public class RetailOrder : Order
    {
        protected override void ProcessDiscounts()
        {
            Console.WriteLine("Retail Order: 5% Discount");
        }

        protected override void ProcessFreight()
        {
            Console.WriteLine("Retail Order: No Freight");
        }

        protected override void ProcessPayment()
        {
            Console.WriteLine("Retail Order: Cards or Cash");
        }
    }
}