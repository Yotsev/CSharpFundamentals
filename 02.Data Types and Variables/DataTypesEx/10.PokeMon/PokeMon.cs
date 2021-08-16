using System;

namespace _10.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int power = pokePower;
            int targets = 0;

            while (power >= distance)
            {
                power -= distance;
                targets++;

                if (power == pokePower / 2 && exhaustionFactor > 0)
                {
                    power /= exhaustionFactor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(targets);
        }
    }
}
