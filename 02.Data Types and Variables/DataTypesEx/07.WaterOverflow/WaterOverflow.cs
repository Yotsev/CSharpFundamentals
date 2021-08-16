using System;

namespace _07.WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            int sumOfliters = 0;

            for (int i = 0; i < numberLines; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (sumOfliters + liters> 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumOfliters += liters;
                }

            }
            Console.WriteLine(sumOfliters);
        }
    }
}
