using System;

namespace TemplateMethod
{
    public class OnlineOrder : Order
    {
        protected override void ProcessDiscounts()
        {
            Console.WriteLine("Online Order: 10% Discount");
        }

        protected override void ProcessFreight()
        {
            Console.WriteLine("Online Order: Freight costs $50");
        }

        protected override void ProcessPayment()
        {
            Console.WriteLine("Online Order: Only Credit or Debit Cards");
        }
    }
}