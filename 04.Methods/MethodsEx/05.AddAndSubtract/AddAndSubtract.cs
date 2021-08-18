using System;

namespace _05.AddAndSubtract
{
    class AddAndSubtract
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = SubtractionFromTheSum(SumOfFirstTwoNumbers(firstNumber, secondNumber), thirdNumber);

            Console.WriteLine(result);
        }

        static int SumOfFirstTwoNumbers (int firstNum, int seconNum)
        {
            int result = firstNum + seconNum;

            return result;
        }

        static int SubtractionFromTheSum(int sum, int thirdNum)
        {
            int result = sum - thirdNum;

            return result;
        }
    }
}
