using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Order onlineOrder = new OnlineOrder();
            onlineOrder.ProcessOrder();

            
            Order retailOrder = new RetailOrder();
            retailOrder.ProcessOrder();


            Console.ReadKey();
        }
    }
}