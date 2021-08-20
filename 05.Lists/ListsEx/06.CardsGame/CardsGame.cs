using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < Math.Min(firstPlayer.Count, secondPlayer.Count); i++)
            {
                if (firstPlayer[i] > secondPlayer[i])
                {
                    WiningHand(firstPlayer, secondPlayer, i);
                    i--;
                }
                else if (firstPlayer[i] == secondPlayer[i])
                {
                    firstPlayer.Remove(firstPlayer[i]);
                    secondPlayer.Remove(secondPlayer[i]);
                    i--;
                }
                else
                {
                    WiningHand(secondPlayer, firstPlayer, i);
                    i--;
                }
            }

            if (firstPlayer.Sum() > secondPlayer.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
        static void WiningHand(List<int> first, List<int> second, int num)
        {
            first.Add(second[num]);
            first.Add(first[num]);
            first.Remove(first[num]);
            second.Remove(second[num]);
        }
    }
}
