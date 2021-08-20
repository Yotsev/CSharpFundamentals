using System;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] times = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double timeOfFirstRacer = 0.0;
            double timeOfSecondRacer = 0.0;

            for (int i = 0; i < times.Length / 2; i++)
            {
                timeOfFirstRacer += times[i];
                
                if (times[i] == 0)
                {
                    timeOfFirstRacer *= 0.8;
                }
            }

            for (int i = times.Length - 1; i > times.Length / 2; i--)
            {
                timeOfSecondRacer += times[i];
                
                if (times[i] == 0)
                {
                    timeOfSecondRacer *= 0.8;
                }
            }

            if (timeOfFirstRacer > timeOfSecondRacer)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(timeOfFirstRacer, 2)}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(timeOfSecondRacer, 2)}");
            }
        }
        
    }
}

