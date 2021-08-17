using System;
using System.Linq;

namespace _06.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isEqual = false;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    isEqual = true;
                    index = i;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
