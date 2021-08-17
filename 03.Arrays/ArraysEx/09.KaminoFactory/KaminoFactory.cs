using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {

            //ПРЕПИСАНА - реших до някъде

            int DNALenght = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int bestLenght = 0;
            int bestIndex = -1;
            int bestSum = 0;
            int bestRow = 0;
            int currentRow = 1;
            int[] bestDNASequence = new int[DNALenght];

            while (command != "Clone them!")
            {
                int[] DNASequence = command
                    .Split("!", StringSplitOptions
                    .RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();

                int currentSum = 0;

                for (int i = 0; i < DNASequence.Length; i++)
                {
                    if (DNASequence[i] == 1)
                    {
                        currentSum++;
                    }
                }

                if (currentRow==1)
                {
                    bestRow = currentRow;
                }

                int currentLenght = 0;
                int currentIndex = -1;
                bool isFound = false;

                for (int i = 0; i < DNASequence.Length; i++)
                {
                    if (DNASequence[i] == 1)
                    {
                        //Най-ценното пърче код = намира първия индекс и не го променя при итерацията.
                        if (!isFound)
                        {
                            currentIndex = i;
                            isFound = true;
                        }

                        currentLenght++;

                        if (bestLenght < currentLenght)
                        {
                            bestLenght = currentLenght;
                            bestSum = currentSum;
                            bestIndex = currentIndex;
                            bestRow = currentRow;
                            bestDNASequence = DNASequence;
                        }
                        else if (bestLenght == currentLenght)
                        {
                            if (bestIndex > currentIndex)
                            {
                                bestLenght = currentLenght;
                                bestSum = currentSum;
                                bestIndex = currentIndex;
                                bestRow = currentRow;
                                bestDNASequence = DNASequence;
                            }
                            else if (bestSum < currentSum)
                            {
                                bestLenght = currentLenght;
                                bestSum = currentSum;
                                bestIndex = currentIndex;
                                bestRow = currentRow;
                                bestDNASequence = DNASequence;
                            }
                        }
                    }
                    else
                    {
                        currentLenght = 0;
                        currentIndex = -1;
                        isFound = false;
                    }
                }
                currentRow++;
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestRow} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ",bestDNASequence));
        }
    }
}
