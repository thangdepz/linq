using System;
using System.Collections.Generic;
using System.Linq;

namespace _21115053120145_huynhkimthang_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car("Toyota Carmy", "Toyota", 2010, 100000, 4),
                new Car("Honda Accord", "Honda", 1900, 200000, 7),
                new Car("Ford F-150", "Ford", 2000, 300000, 4),
                new Car("Toyota Corolla", "Toyota", 2003, 500000, 4),
                new Car("Toyota RAV4", "Toyota", 2022, 600000, 4),
                new Car("Toyota Prius", "Toyota", 1989, 500000, 4),
                new Car("Honda Accord", "Honda", 2004, 200000, 7),
                new Car("Honda Civic", "Honda", 2005, 240000, 7),
                new Car("Ford Mustang", "Ford", 1985, 300000, 4)
            };
            var carsInRange = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
            Console.WriteLine("Cac xe co gia trong khoang 100000 den 250000:");
            foreach (var car in carsInRange)
            {
                Console.WriteLine(car.Name+ " - " + car.Price);
            }
            var carsAfter1990 = cars.Where(car => car.Year > 1990);
            Console.WriteLine("\nCac xe co nam san xuat >1990:");
            foreach (var car in carsAfter1990)
            {
                Console.WriteLine(car.Name +" - " + car.Year);
            }
            var groupedCars = cars.GroupBy(car => car.Brand)
                              .Select(group => new { Brand = group.Key, TotalPrice = group.Sum(car => car.Price) });
            Console.WriteLine("\nTong gia tri theo hang san xuat:");
            foreach (var group in groupedCars)
            {
                Console.WriteLine(group.Brand + " - " + group.TotalPrice);
            }

            List<Truck> trucks = new List<Truck> { 
                new Truck("Volvo FH", "Volvo Trucks", 2002, 300000, "Ryder System, Inc"),
                new Truck("Volvo FM", "Volvo Trucks", 2002, 300000, "XPO Logistics, Inc"),
                new Truck("Volvo FMX", "Volvo Trucks", 2005, 300000, "XPO Logistics, Inc"),
            };
            var sortedTrucksByYear = trucks.OrderBy(truck => truck.Year);
            Console.WriteLine("\nTruck theo thu tu nam san xuat moi nhat:");
            foreach (var truck in sortedTrucksByYear)
            {
                Console.WriteLine(truck.Name + " - " + truck.Year);
            }
            var ownerCompanies = trucks.Select(truck => truck.OwnerCompany).Distinct();
            Console.WriteLine("\nCac cong ty chu quan cua Truck:");
            foreach (var company in ownerCompanies)
            {
                Console.WriteLine(company);
            }
        }


    }
}