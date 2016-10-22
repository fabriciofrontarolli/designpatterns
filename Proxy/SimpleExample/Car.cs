using System;

namespace Proxy.SimpleExample
{
    public class Car : ICar
    {
        public void DriveCar()
        {
            Console.WriteLine("Car has been driven!");
        }
    }
}