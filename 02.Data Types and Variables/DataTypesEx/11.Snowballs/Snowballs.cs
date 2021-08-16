using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger bestSnowball = 0;
            string bestSnowballStats = string.Empty;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                
                if (bestSnowball <= snowballValue)
                {
                    bestSnowball = snowballValue;
                    bestSnowballStats = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }

            Console.WriteLine(bestSnowballStats);
        }
    }
}
