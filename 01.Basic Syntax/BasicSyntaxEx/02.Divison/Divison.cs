using System;

namespace _02.Divison
{
    class Divison
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int firstDivider = 2;
            int secondDivider = 3;
            int thirdDivider = 6;
            int forthDivider = 7;
            int fifthDivider = 10;
            
            int highestDivision = 0;

            if (number%firstDivider==0)
            {
                highestDivision = firstDivider;
            }
            if (number%secondDivider==0)
            {
                highestDivision = secondDivider;
            }
            if (number % thirdDivider == 0)
            {
                highestDivision = thirdDivider;
            }
            if (number % forthDivider == 0)
            {
                highestDivision = forthDivider;
            }
            if (number % fifthDivider == 0)
            {
                highestDivision = fifthDivider;
            }
            if (highestDivision==0)
            {
                Console.WriteLine("Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {highestDivision}");
        }
    }
}
