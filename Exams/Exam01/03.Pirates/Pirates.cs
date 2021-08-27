using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pirates
{
    class Pirates
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();


            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while (command != "Sail")
            {
                string[] commandArgs = command
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);
                string cityName = commandArgs[0];
                int cityPopulation = int.Parse(commandArgs[1]);
                int cityGold = int.Parse(commandArgs[2]);

                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, new List<int>());
                    cities[cityName].Add(cityPopulation);
                    cities[cityName].Add(cityGold);
                }
                else
                {
                    cities[cityName][0] += cityPopulation;
                    cities[cityName][1] += cityGold;
                }

                command = Console.ReadLine();
            }

            string @event = Console.ReadLine();

            while (@event != "End")
            {
                string[] eventArgs = @event
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = eventArgs[0];

                if (action == "Plunder")
                {
                    string townName = eventArgs[1];
                    int peopleKilled = int.Parse(eventArgs[2]);
                    int goldPlundered = int.Parse(eventArgs[3]);

                    Console.WriteLine($"{townName} plundered! {goldPlundered} gold stolen, {peopleKilled} citizens killed.");

                    cities[townName][0] -= peopleKilled;
                    cities[townName][1] -= goldPlundered;

                    if (cities[townName][0] <= 0 || cities[townName][1] <= 0)
                    {
                        cities.Remove(townName);
                        Console.WriteLine($"{townName} has been wiped off the map!");
                    }
                }
                else
                {
                    string townName = eventArgs[1];
                    int gold = int.Parse(eventArgs[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");

                        @event = Console.ReadLine();
                        continue;
                    }

                    cities[townName][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {cities[townName][1]} gold.");
                }

                @event = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities.OrderByDescending(c => c.Value[1]).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
        }
    }
}
