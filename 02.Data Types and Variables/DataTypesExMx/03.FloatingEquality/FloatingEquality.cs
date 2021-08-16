using System;

namespace _03.FloatingEquality
{
    class FloatingEquality
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double eps = eps = 0.000001;

            bool isEqual = false;

            if ((Math.Max(firstNumber,secondNumber) - Math.Min(firstNumber,secondNumber))<eps)
            {
                isEqual = true;
            }

            Console.WriteLine(isEqual);
        }
    }
}
