using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class MovingTarget
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Shoot")
                {
                    int index = int.Parse(commandArgs[1]);
                    int power = int.Parse(commandArgs[2]);

                    if (index >= 0 && targets.Count > index)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (action == "Add")
                {
                    int index = int.Parse(commandArgs[1]);
                    int value = int.Parse(commandArgs[2]);

                    if (index>=0 && targets.Count>index)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (action == "Strike")
                {
                    int index = int.Parse(commandArgs[1]);
                    int radius = int.Parse(commandArgs[2]);

                    if (index-radius>=0 && targets.Count>index+radius)
                    {
                        targets.RemoveRange(index-radius, radius*2+1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
