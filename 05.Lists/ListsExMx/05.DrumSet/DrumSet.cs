using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DrumSet
{
    class DrumSet
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            List<int> initialQuality = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            List<int> currentQuality = initialQuality.ToList();

            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < currentQuality.Count; i++)
                {
                    currentQuality[i] -= hitPower;
                    int price = initialQuality[i] * 3;
                    
                    if (currentQuality[i] <= 0)
                    {
                        if (price>savings)
                        {
                            currentQuality[i] = 0;
                            continue;
                        }
                        else
                        {
                            currentQuality[i] = initialQuality[i];
                            savings -= price;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < currentQuality.Count; i++)
            {
                if (currentQuality[i] == 0)
                {
                    currentQuality.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ",currentQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
