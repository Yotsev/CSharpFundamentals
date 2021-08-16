using System;

namespace _09.SpiceMustFlow
{
    class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int extractedSpice = 0;
            int days = 0;

            while (yield >= 100)
            {
                extractedSpice += yield;
                yield -= 10;
                extractedSpice -= 26;
                days++;
            }
            
            if (days > 0)
            {
                extractedSpice -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(extractedSpice);
        }
    }
}
