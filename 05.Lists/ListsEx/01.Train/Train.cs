using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string []command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (command[0]!="end")
            {

                if (command[0] == "Add")
                {
                    int passengersInWagon = int.Parse(command[1]);
                    AddWagaon(passengers, passengersInWagon);
                }
                else
                {
                    int peopleToAdd = int.Parse(command[0]);
                    AddingPassengers(passengers, peopleToAdd, maxCapacity);
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ",passengers));
        }
        static void AddWagaon(List<int> wagonToAdd, int num)
        {
            wagonToAdd.Add(num);
        }

        static void AddingPassengers (List<int> peopleToAdd, int num, int capacity)
        {
            for (int i = 0; i < peopleToAdd.Count; i++)
            {
                if (peopleToAdd[i] + num <= capacity)
                {
                    peopleToAdd[i] += num;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
