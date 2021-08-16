using System;

namespace _02.PoundsToDollars
{
    class PoundsToDollars
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal USD = pounds * 1.31M;

            Console.WriteLine($"{USD:f3}");

        }
    }
}
