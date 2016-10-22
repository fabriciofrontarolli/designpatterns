using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you CRUDing or Logging ?  : 'crud' :  'logging'");

            var operation = Console.ReadLine();

            var factory = new DatabaseFactory();
            var connection = factory.CreateInstance(operation);

            Console.ReadKey();
        }
    }
}
