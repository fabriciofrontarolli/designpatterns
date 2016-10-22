using System;

namespace Proxy.SimpleExample
{
    public class CarProxy : ICar
    {
        private Driver driver;
        private ICar realCar;

        public CarProxy(Driver driver)
        {
            this.driver = driver;
            realCar = new Car();
        }

        public void DriveCar()
        {
            if (driver.Age <= 16)
                Console.WriteLine("Sorry, the driver is too young to drive.");
            else
                realCar.DriveCar();
        }
    }
}