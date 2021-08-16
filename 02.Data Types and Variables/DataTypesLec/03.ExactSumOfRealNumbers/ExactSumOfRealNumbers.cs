using System;

namespace _03.ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 1; i <= numbers; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());

                sum += input;
            }

            Console.WriteLine(sum);
        }
    }
}
