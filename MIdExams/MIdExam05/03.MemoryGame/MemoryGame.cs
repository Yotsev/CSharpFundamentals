using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    class MemoryGame
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = Console.ReadLine();

            int moves = 0;
            bool isOver = false;
            while (command != "end")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int firstIndex = int.Parse(commandArgs[0]);
                int secondIndex = int.Parse(commandArgs[1]);

                if (firstIndex == secondIndex || firstIndex < 0 || secondIndex < 0 || firstIndex >= numbers.Count || secondIndex>= numbers.Count)
                {
                    moves++;
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    numbers.Insert(numbers.Count / 2, $"-{ moves}a");
                    numbers.Insert(numbers.Count / 2, $"-{ moves}a");
                    command = Console.ReadLine();
                    continue;
                }

                if (numbers[firstIndex] == numbers[secondIndex])
                {
                    moves++;
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[firstIndex]}!");
                    numbers.RemoveAt(firstIndex);
                    if (secondIndex==0)
                    {
                        secondIndex = 1;
                    }
                    numbers.RemoveAt(secondIndex-1);
                    if (numbers.Count == 0)
                    {
                        isOver = true;
                        break;
                    }
                }
                else if (numbers[firstIndex] != numbers[secondIndex])
                {
                    moves++;
                    Console.WriteLine("Try again!");
                }
                command = Console.ReadLine();
            }

            if (isOver)
            {
                Console.WriteLine($"You have won in {moves} turns!");
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
