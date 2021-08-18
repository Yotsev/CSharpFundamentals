using System;
using System.Linq;

namespace _04.TribonacciSequence
{
    class TribonacciSequence
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Sequence(num);
        }

        static void Sequence (int num)
        {
            uint[] tribonacci = new uint [Math.Max(num,3)];
            
            tribonacci[0] = 1;
            tribonacci[1] = 1;
            tribonacci[2] = 2;
            
            if (num<3)
            {
                Console.WriteLine(string.Join(" ",tribonacci.Take(num)));
            }
            else
            {
                for (int i = 3; i < num; i++)
                {
                    tribonacci[i] = tribonacci[i - 3] + tribonacci[i - 2] + tribonacci[i - 1];
                }
                Console.WriteLine(string.Join(" ",tribonacci));
            }
        }
    }
}
