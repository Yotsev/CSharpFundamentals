using System;

namespace _08.TriangleОfNumbers
{
    class TriangleОfNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row-1; col++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine(row);

            }
        }
    }
}
