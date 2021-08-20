using System;
using System.Collections.Generic;
using System.Text;

namespace _03.HouseParty
{
    class HouseParty
    {
        static void Main(string[] args)
        {
            int numberOfCommand = int.Parse(Console.ReadLine());

            List<string> names = new List<string>(numberOfCommand);

            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = command[0];
                string action = GetCommand(command);

                if (action == "is going!")
                {
                    if (!names.Contains(name))
                    {
                        names.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (action == "is not going!")
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join("\n",names));
        }
        static string GetCommand(string[] command)
        {
            StringBuilder action = new StringBuilder();

            for (int j = 1; j < command.Length; j++)
            {
                action.Append(command[j]).Append(" ");
            }
            string actionToString = action.ToString().Trim();
            return actionToString;
        }
    }
}
