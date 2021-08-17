using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[] digits = numbers.Select(int.Parse).ToArray();

            while (digits.Length > 1)
            {
                int[] condensed = new int[digits.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = digits[i] + digits[i + 1];
                }
                
                //digits = condensed;
                
                digits = new int[condensed.Length];

                for (int i = 0; i < condensed.Length; i++)
                {
                    digits[i] = condensed[i];
                }
            }

            Console.WriteLine(digits[0]);
        }
    }
}
