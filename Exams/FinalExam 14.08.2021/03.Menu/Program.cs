using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int unlikedMeals = 0;

            while (command != "Stop")
            {
                string[] commandArgs = command
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                string guest = commandArgs[1];
                string meal = commandArgs[2];

                if (action == "Like")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest, new List<string>());
                    }

                    if (!guests[guest].Contains(meal))
                    {
                        guests[guest].Add(meal);
                    }
                }
                else if (action == "Unlike")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else
                    {
                        if (!guests[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            guests[guest].Remove(meal);
                            unlikedMeals++;
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> guest in guests.OrderByDescending(g => g.Value.Count).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ",guest.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
