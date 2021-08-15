using System;

namespace _02.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string nameOfDigit = string.Empty;
            int lastDigit = number % 10;

            if (lastDigit==0)
            {
                nameOfDigit = "zero";
            }
            else if (lastDigit==1)
            {
                nameOfDigit = "one";
            }
            else if (lastDigit == 2)
            {
                nameOfDigit = "two";
            }
            else if (lastDigit == 3)
            {
                nameOfDigit = "three";
            }
            else if (lastDigit == 4)
            {
                nameOfDigit = "four";
            }
            else if (lastDigit == 5)
            {
                nameOfDigit = "five";
            }
            else if (lastDigit == 6)
            {
                nameOfDigit = "six";
            }
            else if (lastDigit == 7)
            {
                nameOfDigit = "seven";
            }
            else if (lastDigit == 8)
            {
                nameOfDigit = "eight";
            }
            else if (lastDigit == 9)
            {
                nameOfDigit = "nine";
            }

            Console.WriteLine($"{nameOfDigit}");
        }
    }
}
