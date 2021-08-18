using System;

namespace _04.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int triangleLenght = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleLenght; i++)
            {
                PrintLine(1, i);
            }

            for (int i = triangleLenght - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }

        }

        static void PrintLine (int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
