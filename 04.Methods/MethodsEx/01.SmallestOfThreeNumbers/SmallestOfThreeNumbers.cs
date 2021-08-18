using System;

namespace _01.SmallestOfThreeNumbers
{
    class SmallestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = SmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        static int SmallestNumber (int firstNum, int secondNum, int thirdNum)
        {
            int smallestOfFirstTwo = Math.Min(firstNum, secondNum);

            int result = Math.Min(smallestOfFirstTwo, thirdNum);

            return result;
        }
    }
}
