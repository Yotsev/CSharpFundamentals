using System;

namespace _12.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isStrong = false;
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int digit = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isStrong = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digit, isStrong);
                i = digit;
            }
        }
    }
}
