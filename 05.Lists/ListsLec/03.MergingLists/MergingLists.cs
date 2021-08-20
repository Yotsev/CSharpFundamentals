using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class MergingLists
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).
                ToList();

            List<int> finalList = new List<int>(firstList.Count + secondList.Count);

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                finalList.Add(firstList[i]);
                finalList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                finalList.AddRange(Remaining(secondList, firstList));
            }
            else if (secondList.Count > firstList.Count)
            {
                finalList.AddRange(Remaining(firstList, secondList));
            }
            Console.WriteLine(string.Join(" ", finalList));
        }

        static List<int> Remaining(List<int> smallerList, List<int> biggerList)
        {
            List<int> remainingNumber = new List<int>();

            for (int i = smallerList.Count; i < biggerList.Count; i++)
            {
                remainingNumber.Add(biggerList[i]);
            }

            return remainingNumber;
        }
    }
}
