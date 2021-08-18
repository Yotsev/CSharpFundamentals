using System;
using System.Numerics;

namespace _08.FactorialDivision
{
    class FactorialDivision
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            long firstNumFact = Factorial(firstNumber);
            long secondNumFact = Factorial(secondNumber);
                        
            double division = ((double)firstNumFact / secondNumFact);

            Console.WriteLine($"{division:f2}");
        }

        static long Factorial (int num)
        {
            long fact = 1;
            
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            return (fact);
        }
    }
}
