using System;

namespace _06.StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberToChek = number;

            int individualNum = 0;
            int factorial = 1;
            int sum = 0;

            while (number > 0)
            {
                individualNum = number % 10;
                for (int i = 1; i <= individualNum; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
                factorial = 1;
                number /= 10;
            }
            if (sum==numberToChek)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
