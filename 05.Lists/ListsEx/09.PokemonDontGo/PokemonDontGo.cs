using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<int> distanceToPokemon = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int index = int.Parse(Console.ReadLine());

            int sum = 0;

            while (distanceToPokemon.Count > 0)
            {
                int removedElementValue = 0;

                if (index < 0)
                {
                    removedElementValue = distanceToPokemon[0];
                    distanceToPokemon.RemoveAt(0);

                    IncreaseDecreaseValue(distanceToPokemon,removedElementValue);

                    distanceToPokemon.Insert(0, distanceToPokemon[distanceToPokemon.Count - 1]);
                }
                else if (index > distanceToPokemon.Count-1)
                {
                    removedElementValue = distanceToPokemon[distanceToPokemon.Count - 1];
                    distanceToPokemon.RemoveAt(distanceToPokemon.Count-1);

                    IncreaseDecreaseValue(distanceToPokemon,removedElementValue);

                    distanceToPokemon.Insert(distanceToPokemon.Count, distanceToPokemon[0]);
                }
                else
                {
                    removedElementValue = distanceToPokemon[index];
                    distanceToPokemon.RemoveAt(index);

                    IncreaseDecreaseValue(distanceToPokemon, removedElementValue);
                }
                
                sum += removedElementValue;
              
                if (distanceToPokemon.Count <= 0)
                {
                    break;
                }

                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }

        static void IncreaseDecreaseValue(List<int> numbers, int element)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= element)
                {
                    numbers[i] += element;
                }
                else
                {
                    numbers[i] -= element;
                }
            }
        }
    }
}
