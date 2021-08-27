using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeedIII
{
    class NeedForSpeedIII
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            int mileageThreshold = 100000;

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] car = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string carModel = car[0];
                int carMileage = int.Parse(car[1]);
                int carFuel = int.Parse(car[2]);

                cars.Add(new Car(carModel, carMileage, carFuel));
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "Drive")
                {
                    string carModel = commandArgs[1];
                    int distance = int.Parse(commandArgs[2]);
                    int fuel = int.Parse(commandArgs[3]);

                    Car car = GetCar(carModel, cars);

                    car.Drive(distance, fuel);

                    if (car.Mileage >= mileageThreshold)
                    {
                        cars.Remove(car);
                        Console.WriteLine($"Time to sell the {car.Model}!");
                    }
                }
                else if (action == "Refuel")
                {
                    string carModel = commandArgs[1];
                    int fuel = int.Parse(commandArgs[2]);

                    Car car = GetCar(carModel, cars);

                    car.Refuel(fuel);
                }
                else if (action == "Revert")
                {
                    string carModel = commandArgs[1];
                    int kilometers = int.Parse(commandArgs[2]);

                    Car car = GetCar(carModel, cars);

                    car.Revert(kilometers);
                }

                command = Console.ReadLine();
            }

            foreach (Car car in cars.OrderByDescending(m => m.Mileage).ThenBy(n => n.Model))
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        private static Car GetCar(string car, List<Car> cars)
        {
            foreach (var item in cars)
            {
                if (item.Model == car)
                {
                    return item;
                }
            }

            return null;
        }
    }
    class Car
    {
        public Car(string model, int mileage, int fuel)
        {
            Model = model;
            Mileage = mileage;
            Fuel = fuel;
        }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public void Drive(int distance, int gas)
        {
            if (Fuel < gas)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                Mileage += distance;
                Fuel -= gas;
                Console.WriteLine($"{Model} driven for {distance} kilometers. {gas} liters of fuel consumed.");
            }
        }

        public void Refuel(int gas)
        {
            int maxFuel = 75;
            int currentfuel = Fuel;
            Fuel += gas;

            if (Fuel > maxFuel)
            {
                Console.WriteLine($"{Model} refueled with {maxFuel - currentfuel} liters");
                Fuel = 75;
            }
            else
            {
                Console.WriteLine($"{Model} refueled with {gas} liters");
            }
        }

        public void Revert(int km)
        {
            int minMileage = 10000;

            Mileage -= km;

            if (Mileage >= 10000)
            {
                Console.WriteLine($"{Model} mileage decreased by {km} kilometers");
            }
            else
            {
                Mileage = minMileage;
            }
        }
    }
}
