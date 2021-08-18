using System;

namespace _03.Calculations
{
    class Calculations
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(firstNumber, secondNumber);
            }
            else if (command == "multiply")
            {
                Multiply(firstNumber, secondNumber);
            }
            else if (command == "subtract")
            {
                Subtract(firstNumber, secondNumber);
            }
            else if (command == "divide")
            {
                Divide(firstNumber, secondNumber);
            }
        }

        static void Add(int firstNum, int SecondNum)
        {
            Console.WriteLine(firstNum + SecondNum);
        }
        static void Multiply(int firstNum, int SecondNum)
        {
            Console.WriteLine(firstNum * SecondNum);
        }
        static void Subtract(int firstNum, int SecondNum)
        {
            Console.WriteLine(firstNum - SecondNum);
        }
        static void Divide(int firstNum, int SecondNum)
        {
            Console.WriteLine(firstNum / SecondNum);
        }
    }
}
