using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> topNumbers = new List<int>();

            double avg = numbers.Sum() / (double)numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > avg)
                {
                    topNumbers.Add(numbers[i]);
                }
            }
            
            topNumbers.Sort((a, b) => b.CompareTo(a));
            
            if (topNumbers.Count>0)
            {
                Console.WriteLine(string.Join(" ", topNumbers.Take(5)));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
