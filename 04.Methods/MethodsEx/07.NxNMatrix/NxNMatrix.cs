using System;

namespace _07.NxNMatrix
{
    class NxNMatrix
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintMatrixNxN(number);
        }

        static void PrintMatrixNxN (int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write(num + " ".TrimEnd());
                }
                Console.WriteLine();
            }
        }
    }
}
