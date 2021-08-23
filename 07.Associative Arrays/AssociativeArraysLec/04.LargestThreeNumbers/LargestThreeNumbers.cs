using System;
using System.Linq;

namespace _04.LargestThreeNumbers
{
    class LargestThreeNumbers
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(x=>x)
                .ToArray();
            int[] numbersToPrint = number.Take(3).ToArray();

            Console.WriteLine(string.Join(" ",numbersToPrint));
        }
    }
}
