using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateProductionManufacturer = new DateTime(1983, 1, 1);
            DateTime dateProductionSeller = new DateTime(2000, 1, 1);
            DateTime dateProductionCar = new DateTime(2018, 2, 1);
            DateTime currDate = new DateTime(2020, 2, 4);
            Manufacturer m = new Manufacturer("Kia Sorento Group", dateProductionManufacturer, 083456772, 40000);
            Seller s = new Seller("SellingCars", dateProductionSeller, 123, 95);
            Owner o = new Owner("Roman", 111);

            Console.WriteLine("------- Iнформацiя про автомобiль -------");

            Automobile auto = new Automobile("Kia", "white", 1111, m, s, o, dateProductionCar);
            Console.WriteLine(auto);
            Console.WriteLine($"Вiк машини - {auto.GetAge(currDate)}");
        }
    }
}
