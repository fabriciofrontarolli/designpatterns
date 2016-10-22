using Proxy.SimpleExample;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new CarProxy(new Driver(16));
            car.DriveCar();

            car = new CarProxy(new Driver(25));
            car.DriveCar();

            Console.ReadKey();
        }
    }
}