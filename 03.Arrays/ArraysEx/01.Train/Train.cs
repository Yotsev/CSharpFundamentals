using System;

namespace _01.Train
{
    class Train
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] passengersInWagon = new int[wagons];
            int totalPassengers = 0;

            for (int i = 0; i < wagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                passengersInWagon[i] = people;
                totalPassengers += people;
            }

            Console.WriteLine($"{string.Join(" ", passengersInWagon)}\n{totalPassengers}");
        }
    }
}
