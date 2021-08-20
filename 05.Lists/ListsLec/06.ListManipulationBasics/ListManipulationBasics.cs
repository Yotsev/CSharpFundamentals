using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class ListManipulationBasics
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] instructions = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = instructions[0];

                if (action == "Add")
                {
                    int num = int.Parse(instructions[1]);

                    numbers.Add(num);
                }
                else if (action == "Remove")
                {
                    int num = int.Parse(instructions[1]);
                    numbers.Remove(num);
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(instructions[1]);
                    numbers.RemoveAt(index);
                }
                else if (action == "Insert")
                {
                    int num = int.Parse(instructions[1]);
                    int index = int.Parse(instructions[2]);
                    numbers.Insert(index,num);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
