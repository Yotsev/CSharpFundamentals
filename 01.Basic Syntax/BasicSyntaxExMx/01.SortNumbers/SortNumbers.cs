using System;

namespace _01.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int temp = firstNumber;

            if (secondNumber > firstNumber)
            {
                temp = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temp;
            }
            if (thirdNumber > firstNumber)
            {
                temp = thirdNumber;
                thirdNumber = firstNumber;
                firstNumber = temp;
            }
            if (thirdNumber>secondNumber)
            {
                temp = thirdNumber;
                thirdNumber = secondNumber;
                secondNumber = temp;
            }

            Console.WriteLine($"{firstNumber}\n{secondNumber}\n{thirdNumber}");
        }
    }
}
