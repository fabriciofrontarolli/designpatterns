using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get DB Instance
            var myConnection = DatabaseConnection.GetConnection();

            Console.WriteLine(DatabaseConnection.InstantiatedTime);

            // Wait a while
            Thread.Sleep(2500);

            // Get DB Instance again
            myConnection = DatabaseConnection.GetConnection();
            Console.WriteLine(DatabaseConnection.InstantiatedTime);

            Console.ReadKey();
        }
    }
}