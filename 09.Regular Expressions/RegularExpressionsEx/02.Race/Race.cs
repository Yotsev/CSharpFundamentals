using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02.Race
{
    class Race
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();

            string namePattern = @"(?<name>[A-Za-z])";
            string distancePattern = @"(?<distance>[0-9])";

            Dictionary<string, int> drivers = new Dictionary<string, int>();

            while (input != "end of race")
            {
                string fullName = string.Empty;
                int fullDustance = 0;

                MatchCollection name = Regex.Matches(input, namePattern);
                MatchCollection distance = Regex.Matches(input, distancePattern);

                foreach (Match letter in name)
                {
                    fullName += letter.Value;
                }

                foreach (Match digit in distance)
                {
                    fullDustance += int.Parse(digit.Value);
                }

                foreach (string participant in participants)
                {
                    if (fullName == participant)
                    {
                        if (!drivers.ContainsKey(fullName))
                        {
                            drivers.Add(fullName, fullDustance);
                            break;
                        }
                        else
                        {
                            drivers[fullName] += fullDustance;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            List<string> ordaredDrivers = new List<string>();
            foreach (KeyValuePair<string, int> driver in drivers.OrderByDescending(d => d.Value))
            {
                ordaredDrivers.Add(driver.Key);
            }

            List<string> topDrivers = ordaredDrivers.Take(3).ToList();

            string[] suffix = new[] { "st", "nd", "rd" };

            for (int i = 0; i < topDrivers.Count; i++)
            {
                Console.WriteLine($"{i + 1}{suffix[i]} place: {topDrivers[i]}");
            }
        }
    }
}
