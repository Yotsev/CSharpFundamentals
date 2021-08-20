using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string [] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    
                    numbers.RemoveAll(n => n == element);
                }
                else if (command[0] == "Insert")
                {
                    int elemetn = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    numbers.Insert(position, elemetn);
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
