using System;
using System.Linq;

namespace _05.TopIntegers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string bigger = string.Empty;
                       
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isBigger = true;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    bigger += numbers[i] + " ";
                }
            }

            Console.WriteLine(bigger);
        }
    }
}
