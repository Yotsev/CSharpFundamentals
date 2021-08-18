using System;

namespace _10.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = MultipleOfEvenAndOdd(number);

            Console.WriteLine(result);
        }
        static int SumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 1)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }

            return sum;
        }
        static int SumOfEvenDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }

            return sum;
        }

        static int MultipleOfEvenAndOdd(int number)
        {
            int sumOfOdd = SumOfOddDigits(number);
            int sumOfEven = SumOfEvenDigits(number);

            int result = sumOfOdd * sumOfEven;

            return result;
        }
    }
}
