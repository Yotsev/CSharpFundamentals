using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = command[0];
                int speed = int.Parse(command[1]);
                int power = int.Parse(command[2]);
                int weight = int.Parse(command[3]);
                string type = command[4];

                Car car = new Car(model, speed, power, weight, type);

                cars.Add(car);
            }

            string finalCommand = Console.ReadLine();

            if (finalCommand == "fragile")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == finalCommand && car.Cargo.Weight<1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (finalCommand == "flamable")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == finalCommand && car.Engine.Power>250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            
            Engine = new Engine();
            Engine.Speed = speed;
            Engine.Power = power;
            
            Cargo = new Cargo();
            Cargo.Weight = weight;
            Cargo.Type = type;
        }
        public string Model { get; set; }
        
        public Engine Engine { get; set; }
        
        public Cargo Cargo { get; set; }
    }

    class Engine
    {
        public int Speed { get; set; }
     
        public int Power { get; set; }
    }

    class Cargo
    {
        public string Type { get; set; }
       
        public int Weight { get; set; }
    }
}
