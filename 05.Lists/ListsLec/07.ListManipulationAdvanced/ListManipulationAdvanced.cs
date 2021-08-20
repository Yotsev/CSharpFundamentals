using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            bool isChanged = false;
            
            while (command != "end")
            {
                string[] instructions = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = instructions[0];

                if (action == "Add")
                {
                    int num = int.Parse(instructions[1]);

                    numbers.Add(num);
                    isChanged = true;
                }
                else if (action == "Remove")
                {
                    int num = int.Parse(instructions[1]);
                    numbers.Remove(num);
                    isChanged = true;
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(instructions[1]);
                    numbers.RemoveAt(index);
                    isChanged = true;
                }
                else if (action == "Insert")
                {
                    int num = int.Parse(instructions[1]);
                    int index = int.Parse(instructions[2]);
                    numbers.Insert(index, num);
                    isChanged = true;
                }
                else if (action == "Contains")
                {
                    int num = int.Parse(instructions[1]);
                    bool isFound = numbers.Contains(num);

                    if (isFound)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> even = numbers.FindAll(n => n % 2 == 0);
                    Console.WriteLine(string.Join(" ", even));
                }
                else if (action == "PrintOdd")
                {
                    List<int> odd = numbers.FindAll(n => n % 2 == 1);
                    Console.WriteLine(string.Join(" ", odd));
                }
                else if (action== "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (action == "Filter")
                {
                    string condition = instructions[1];
                    int num = int.Parse(instructions[2]);
                    List<int> result = new List<int>();

                    if (condition == "<")
                    {
                        result = numbers.FindAll(n => n < num);
                    }
                    else if (condition == ">")
                    {
                        result = numbers.FindAll(n => n > num);
                    }
                    else if (condition == ">=")
                    {
                        result = numbers.FindAll(n => n >= num);
                    }
                    else if (condition == "<=")
                    {
                        result = numbers.FindAll(n => n <= num);
                    }

                    Console.WriteLine(string.Join(" ", result));
                }
                
                command = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
