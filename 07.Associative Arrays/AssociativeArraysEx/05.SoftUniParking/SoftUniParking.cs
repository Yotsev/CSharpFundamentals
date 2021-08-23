using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftUniParking
{
    class SoftUniParking
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commad = commandArgs[0];

                if (commad == "register")
                {
                    string userName = commandArgs[1];
                    string licensePlateNumber = commandArgs[2];

                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[userName]}");
                    }
                    else
                    {
                        users.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                }
                else if (commad == "unregister")
                {
                    string userName = commandArgs[1];

                    if (!users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        users.Remove(userName);
                    }
                }
            }

            foreach (KeyValuePair<string, string> user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
