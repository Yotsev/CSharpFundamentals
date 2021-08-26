using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class ShootForTheWin
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            int shotTargets = 0;

            while (command != "End")
            {
                int index = int.Parse(command);

                if (index >= 0 && targets.Length > index)
                {
                    shotTargets++;
                    int currentTarget = targets[index];
                    targets[index] = -1;

                    if (currentTarget != -1)
                    {
                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] == -1)
                            {
                                continue;
                            }
                            else if (targets[i] > currentTarget)
                            {
                                targets[i] -= currentTarget;
                            }
                            else if (targets[i] <= currentTarget)
                            {
                                targets[i] += currentTarget;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }
    }
}
