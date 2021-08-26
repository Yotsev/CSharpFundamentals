using System;

namespace _01.ProblemOne
{
    class ProblemOne
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorker = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int numberOfBiscuitsCompetingFactory = int.Parse(Console.ReadLine());

            int dayLimit = 30;
            int daysCount = 0;

            double totalBiscuitsPerDay = biscuitsPerWorker * countOfWorkers;
            double totalBiscuitsPerDayEverythirdDay = Math.Floor((biscuitsPerWorker * countOfWorkers) * 0.75);
            double totoalBiscuits = 0;

            while (daysCount != dayLimit)
            {
                if (daysCount % 3 == 0)
                {
                    totoalBiscuits += totalBiscuitsPerDayEverythirdDay;
                }
                else
                {
                    totoalBiscuits += totalBiscuitsPerDay;
                }

                daysCount++;
            }
            double differenceBetweenFactories = 0.0;

            string moreOrLess = string.Empty;

            if (totoalBiscuits > numberOfBiscuitsCompetingFactory)
            {
                differenceBetweenFactories = totoalBiscuits - numberOfBiscuitsCompetingFactory;
                moreOrLess = "more";
            }
            else
            {
                differenceBetweenFactories = numberOfBiscuitsCompetingFactory - totoalBiscuits;
                moreOrLess = "less";
            }

            double percentage = differenceBetweenFactories / numberOfBiscuitsCompetingFactory * 100;

            Console.WriteLine($"You have produced {totoalBiscuits} biscuits for the past month.");
            Console.WriteLine($"You produce {percentage:f2} percent {moreOrLess} biscuits.");
        }
    }
}
