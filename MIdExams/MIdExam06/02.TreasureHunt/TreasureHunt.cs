using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TreasureHunt
{
    class TreasureHunt
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = Console.ReadLine();
            
            double averageGain = 0.0;

            while (command != "Yohoho!")
            {
                string[] commandArgas = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgas[0];

                if (action == "Loot")
                {
                    for (int i = 1; i < commandArgas.Length; i++)
                    {
                        if (!treasure.Contains(commandArgas[i]))
                        {
                            treasure.Insert(0, commandArgas[i]);
                        }
                    }
                }
                else if (action == "Drop")
                {
                    int index = int.Parse(commandArgas[1]);
                    if (index >= 0 && treasure.Count > index)
                    {
                        string item = treasure[index];
                        treasure.RemoveAt(index);
                        treasure.Add(item);
                    }
                }
                else if (action == "Steal")
                {
                    int count = int.Parse(commandArgas[1]);
                    if (count>treasure.Count)
                    {
                        count = treasure.Count;
                    }

                    Console.WriteLine(string.Join(", ", treasure.TakeLast(count)));
                    treasure.RemoveRange(treasure.Count - count, count);
                }

                int itemsValue = 0;

                for (int i = 0; i < treasure.Count; i++)
                {
                    int valueOfItem = treasure[i].Length;
                    itemsValue += valueOfItem;
                }
                averageGain = (double)itemsValue / treasure.Count;

                command = Console.ReadLine();
            }

            if (treasure.Count>0)
            {
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
