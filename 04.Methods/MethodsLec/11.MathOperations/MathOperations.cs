using System;

namespace _11.MathOperations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = ResultOfAction(firstNumber, action, secondNumber);

            Console.WriteLine(result);
        }
        static double ResultOfAction(int firstnum, char action, int secondNum)
        {
            double result = 0;
            if (action=='+')
            {
                result = firstnum + secondNum;
            }
            else if (action=='-')
            {
                result = firstnum - secondNum;
            }
            else if (action=='*')
            {
                result = firstnum * secondNum;
            }
            else if (action=='/')
            {
                result = firstnum / secondNum;
            }

            return result;
        }
    }
}
