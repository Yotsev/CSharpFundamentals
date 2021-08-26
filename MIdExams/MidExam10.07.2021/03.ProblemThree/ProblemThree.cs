using System;
using System.Linq;

namespace _03.ProblemThree
{
    class ProblemThree
    {
        static void Main(string[] args)
        {
            int[] itemsPriceRatings = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();

            int leftSum = 0;
            int rightSum = 0;

            if (typeOfItems == "cheap")
            {
                for (int i = entryPoint; i >= 1; i--)
                {
                    if (itemsPriceRatings[i-1] < itemsPriceRatings[entryPoint])
                    {
                        leftSum += itemsPriceRatings[i-1];
                    }
                }
                for (int i = entryPoint; i < itemsPriceRatings.Length-1; i++)
                {
                    if (itemsPriceRatings[i+1] < itemsPriceRatings[entryPoint])
                    {
                        rightSum += itemsPriceRatings[i+1];
                    }
                }
            }
            else if(typeOfItems == "expensive")
            {
                for (int i = entryPoint; i >= 1; i--)
                {
                    if (itemsPriceRatings[i-1] >= itemsPriceRatings[entryPoint])
                    {
                        leftSum += itemsPriceRatings[i-1];
                    }
                }
                for (int i = entryPoint; i < itemsPriceRatings.Length-1; i++)
                {
                    if (itemsPriceRatings[i+1] >= itemsPriceRatings[entryPoint])
                    {
                        rightSum += itemsPriceRatings[i+1];
                    }
                }
            }

            string position = string.Empty;
            int mostDamage = 0;
            if (leftSum >= rightSum)
            {
                position = "Left";
                mostDamage = leftSum;
            }
            else if (leftSum < rightSum)
            {
                position = "Right";
                mostDamage = rightSum;
            }

            Console.WriteLine($"{position} - {mostDamage}");
        }
    }
}
