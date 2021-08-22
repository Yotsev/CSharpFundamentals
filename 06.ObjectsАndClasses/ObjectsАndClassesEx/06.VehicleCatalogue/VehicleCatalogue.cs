using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Vehicle> vehicles = new List<Vehicle>();

            while (command != "End")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = commandArgs[0];
                string model = commandArgs[1];
                string color = commandArgs[2];
                int hp = int.Parse(commandArgs[3]);

                Vehicle vehicle = new Vehicle
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = hp
                };

                vehicles.Add(vehicle);

                command = Console.ReadLine();
            }

            string newCommand = Console.ReadLine();

            while (newCommand != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == newCommand)
                    {
                        if (vehicle.Type == "car")
                        {
                            Console.WriteLine("Type: Car");
                        }
                        else
                        {
                            Console.WriteLine("Type: Truck");
                        }

                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }

                newCommand = Console.ReadLine();
            }

            double carsHp = AvgHorsepowerByType(vehicles, "car");
            double truckHp = AvgHorsepowerByType(vehicles, "truck");

            Console.WriteLine($"Cars have average horsepower of: {carsHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckHp:f2}.");
        }

        static double AvgHorsepowerByType(List<Vehicle> vehicles, string type)
        {
            int typeCount = 0;
            int typeTotalHorsepower = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Type == type)
                {
                    typeCount++;
                    typeTotalHorsepower += vehicle.Horsepower;
                }
            }

            if (typeCount == 0)
            {
                return 0;
            }

            double avgHp = (double)typeTotalHorsepower / typeCount;

            return avgHp;
        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
}
