using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Catalog catalog = new Catalog();

            while (command != "end")
            {
                string[] tokens = command.Split("/", StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];

                if (type == "Car")
                {
                    int hp = int.Parse(tokens[3]);
                    catalog.Cars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = hp
                    });

                }
                else if (type == "Truck")
                {
                    int weight = int.Parse(tokens[3]);

                    catalog.Trucks.Add(new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    });
                }

                command = Console.ReadLine();
            }

            if (catalog.Cars.Count>0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count>0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
}
