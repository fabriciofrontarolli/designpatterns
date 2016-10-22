using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single entry point to add customer
            var customerFacade = new CustomerFacade();
            customerFacade.AddCustomer();

            Console.ReadKey();
        }
    }
}