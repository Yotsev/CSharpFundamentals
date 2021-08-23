using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount[numbers[i]]++;
                }
                else
                {
                    numbersCount.Add(numbers[i], 1);
                }
            }

            foreach (KeyValuePair<double, int> number in numbersCount)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
