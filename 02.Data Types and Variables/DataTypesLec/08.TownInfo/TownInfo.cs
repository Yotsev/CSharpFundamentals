using System;

namespace _08.TownInfo
{
    class TownInfo
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int squareKm = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {city} has population of {population} and area {squareKm} square km.");
        }
    }
}
