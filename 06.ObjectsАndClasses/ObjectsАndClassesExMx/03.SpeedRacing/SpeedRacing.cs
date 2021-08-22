using System;
using System.Collections.Generic;

namespace _03.SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < number; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fluelAmount = double.Parse(carInfo[1]);
                double fluelConsumption = double.Parse(carInfo[2]);

                Car newCar = new Car
                {
                    Model = model,
                    FluelAmount = fluelAmount,
                    FluelConsumptionParKm = fluelConsumption
                };

                cars.Add(newCar);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = commandArgs[1];
                int amountOfKm = int.Parse(commandArgs[2]);

                foreach (Car car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Drive(amountOfKm);
                    }
                }
            
                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FluelAmount:f2} {car.TravelDistance}");
            }
        }
    }

    class Car
    {
        public string Model { get; set; }
        public double FluelAmount { get; set; }
        public double FluelConsumptionParKm { get; set; }
        public double TravelDistance { get; set; }

        public void Drive(int kmTotravel)
        {
            double fluellNeeded = FluelConsumptionParKm * kmTotravel;

            if (fluellNeeded <= FluelAmount)
            {
                TravelDistance += kmTotravel;
                FluelAmount -= fluellNeeded;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
