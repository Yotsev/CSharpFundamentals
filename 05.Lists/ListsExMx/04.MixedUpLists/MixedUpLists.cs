using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    class MixedUpLists
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> totalList = new List<int>();
            List<int> constrains = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count,secondList.Count); i++)
            {
                totalList.Add(firstList[i]);
                totalList.Add(secondList[secondList.Count - 1 - i]);
            }

            if (firstList.Count>secondList.Count)
            {
                constrains.AddRange(firstList.TakeLast(2));
                constrains.Sort();
            }
            else
            {
                constrains.AddRange(secondList.Take(2));
                constrains.Sort();
            }

            List<int> finalList = new List<int>();

            finalList.AddRange(totalList.Where(n => n > constrains[0] && n < constrains[1]));
            finalList.Sort();

            Console.WriteLine(string.Join(" ",finalList));
        }
    }
}
