using System;

namespace _01.SignOfIntegerNumbers
{
    class SignOfIntegerNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            NumbersSign(number);
        }

        static void NumbersSign(int number)
        {
            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
