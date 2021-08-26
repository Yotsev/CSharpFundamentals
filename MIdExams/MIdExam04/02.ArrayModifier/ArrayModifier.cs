using System;
using System.Linq;

namespace _02.ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                

                if (action == "swap")
                {
                    int firstIndex = int.Parse(commandArgs[1]);
                    int secondIndex = int.Parse(commandArgs[2]);

                    int temp = 0;
                    temp = numbers[firstIndex];
                    numbers[firstIndex] = numbers[secondIndex];
                    numbers[secondIndex] = temp;

                }
                else if (action == "multiply")
                {
                    int firstIndex = int.Parse(commandArgs[1]);
                    int secondIndex = int.Parse(commandArgs[2]);

                    numbers[firstIndex] *= numbers[secondIndex];
                }
                else if (action == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
