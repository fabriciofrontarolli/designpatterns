using System;

namespace TemplateMethod
{
    public abstract class Order
    {
        //Template Method to Process Orders
        public void ProcessOrder()
        {
            Console.WriteLine("Order being processed by Template Method.");
            ProcessDiscounts();
            ProcessFreight();
            ProcessPayment();
        }

        protected abstract void ProcessDiscounts();

        protected abstract void ProcessFreight();

        protected abstract void ProcessPayment();
    }
}