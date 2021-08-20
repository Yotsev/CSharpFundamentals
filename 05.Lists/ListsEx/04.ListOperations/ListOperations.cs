using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ListOperations
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    int numberToAdd = int.Parse(command[1]);
                    numbers.Add(numberToAdd);
                }
                else if (command[0] == "Insert")
                {
                    int numberToInsert = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (index < 0 || numbers.Count <= index)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, numberToInsert);
                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || numbers.Count <= index)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command[0] == "Shift")
                {
                    int count = int.Parse(command[2]);

                    if (command[1] == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (command[1]== "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ",numbers));

            static void ShiftLeft(List<int> nums, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    int temp = nums[0];
                    nums.RemoveAt(0);
                    nums.Add(temp);
                }
            }

            static void ShiftRight(List<int> nums, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    int temp = nums[nums.Count-1];
                    nums.RemoveAt(nums.Count-1);
                    nums.Insert(0, temp);
                }
            }
        }
    }
}
