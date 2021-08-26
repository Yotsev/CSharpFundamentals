using System;
using System.Linq;

namespace _03.HeartDelivery
{
    class HeartDelivery
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            int cupidPositon = 0;
            int count = 0;

            while (command != "Love!")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int lenght = int.Parse(commandArgs[1]);

                if (cupidPositon + lenght > neighborhood.Length-1)
                {
                    cupidPositon = 0;
                    if (neighborhood[cupidPositon] == 0)
                    {
                        Console.WriteLine($"Place {cupidPositon} already had Valentine's day.");
                        command = Console.ReadLine();
                        continue;
                    }
                   
                    neighborhood[cupidPositon] -= 2;
                   
                    if (neighborhood[cupidPositon] == 0)
                    {
                        Console.WriteLine($"Place {cupidPositon} has Valentine's day.");
                        count++;
                    }
                }
                else
                {
                    cupidPositon += lenght;
                    if (neighborhood[cupidPositon] == 0)
                    {
                        Console.WriteLine($"Place {cupidPositon} already had Valentine's day.");
                        command = Console.ReadLine();
                        continue;
                    }
                    
                    neighborhood[cupidPositon] -= 2;
                    
                    if (neighborhood[cupidPositon] == 0)
                    {
                        Console.WriteLine($"Place {cupidPositon} has Valentine's day.");
                        count++;
                    }
                }
                command = Console.ReadLine();
            }
            
            Console.WriteLine($"Cupid's last position was {cupidPositon}.");
            
            if (count == neighborhood.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Length-count} places.");
            }
        }
    }
}
