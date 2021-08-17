using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class EvenAndOddSubtraction
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber%2==0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            int subtraction = evenSum - oddSum;

            Console.WriteLine(subtraction);
        }
    }
}
