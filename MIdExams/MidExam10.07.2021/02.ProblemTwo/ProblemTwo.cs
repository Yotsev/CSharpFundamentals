using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.ProblemTwo
{
    class ProblemTwo
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(commandArgs[1]);

                    numbers.Add(numberToAdd);
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(commandArgs[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (action == "Replace")
                {
                    int numberToReplace = int.Parse(commandArgs[1]);
                    int newNumber = int.Parse(commandArgs[2]);

                    if (numbers.Contains(numberToReplace))
                    {
                        int index = numbers.IndexOf(numberToReplace);
                        numbers[index] = newNumber;
                    }
                }
                else if (action == "Collapse")
                {
                    int numberToCompare = int.Parse(commandArgs[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]< numberToCompare)
                        {
                            numbers.Remove(numbers[i]);
                            i--;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
