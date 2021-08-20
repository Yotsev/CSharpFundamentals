using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split(" ", StringSplitOptions
                .RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int numberToBomb = bomb[0];
            int range = bomb[1];

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == numberToBomb)
                {
                    int indexOfElement = sequence.IndexOf(numberToBomb);

                    if (range > 0)
                    {
                        if (range <= indexOfElement)
                        {
                            sequence.RemoveRange(indexOfElement - range, range);
                            indexOfElement = sequence.IndexOf(numberToBomb);
                        }
                        else
                        {
                            sequence.RemoveRange(0, indexOfElement);
                            indexOfElement = sequence.IndexOf(numberToBomb);
                        }
                    }

                    if (range <= sequence.Count - 1 - indexOfElement)
                    {
                        sequence.RemoveRange(indexOfElement + 1, range);
                    }
                    else if (indexOfElement == sequence.Count - 1)
                    {
                        sequence.Remove(numberToBomb);
                    }
                    else
                    {
                        sequence.RemoveRange(indexOfElement + 1, range - indexOfElement);
                    }

                    sequence.Remove(numberToBomb);
                    i = -1;
                }
            }

            Console.WriteLine(sequence.Sum());
        }
    }
}
