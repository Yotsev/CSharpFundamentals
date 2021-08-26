using System;
using System.Linq;

namespace _02.TheLift
{
    class TheLift
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxCapacity = 4;
            int currentpeople = people;

            for (int i = 0; i < lift.Length; i++)
            {
                if (people == 0)
                {
                    break;
                }
                if (lift[i] == maxCapacity)
                {
                    continue;
                }
                else
                {
                    int peopleInWagon = lift[i];
                    
                    if (peopleInWagon == 0 && currentpeople>=4)
                    {
                        lift[i] = maxCapacity;
                        currentpeople -= maxCapacity;
                    }
                    else if (peopleInWagon == 0 && currentpeople < maxCapacity)
                    {
                        lift[i] = currentpeople;
                        currentpeople -= lift[i];
                    }
                    else
                    {
                        lift[i] = maxCapacity;
                        currentpeople -= maxCapacity-peopleInWagon;
                    }
                }
            }

            int count = 0;

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] == 4)
                {
                    count++;
                }
            }

            if (currentpeople == 0 && count != lift.Length)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (currentpeople == 0 && count == lift.Length)
            {
                Console.WriteLine(string.Join(" ",lift));
            }
            else if (currentpeople >= 0)
            {
                Console.WriteLine($"There isn't enough space! {currentpeople} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }

            // TODO: 88 point first test fail
        }
    }
}
