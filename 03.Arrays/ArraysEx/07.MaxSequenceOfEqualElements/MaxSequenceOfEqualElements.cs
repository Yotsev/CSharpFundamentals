using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int index = 0;
            int count = 1;
            int biggestSequence = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (biggestSequence < count)
                    {
                        biggestSequence = count;
                        index = i + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = index; i > index - biggestSequence; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
