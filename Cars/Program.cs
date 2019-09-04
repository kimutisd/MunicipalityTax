namespace Cars
{
    using System;
    using CarModels;

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("ABC123");
            var petrolCar = new PetrolCar("AAA000");
            var electricCar = new ElectricCar("EVO123");

            Console.WriteLine(CarAgent.GetLicenseNumber(car));
            Console.WriteLine(CarAgent.GetLicenseNumber(petrolCar));
            Console.WriteLine(CarAgent.GetLicenseNumber(electricCar));
            Console.ReadKey();
        }
    }
}