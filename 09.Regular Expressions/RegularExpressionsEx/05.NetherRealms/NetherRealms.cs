using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _05.NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^0-9+\-*\/.]";
            string damagePattern = @"((?:\+|-)?\d+\.?\d*)";
            string additionalActionPattern = @"([*/])";

            char[] separators = new[] { ' ', '\t', ',' };

            string[] demons = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<double>> demonsInfo = new Dictionary<string, List<double>>();

            foreach (string demon in demons)
            {
                double health = GetHealth(demon, healthPattern);
                double damage = GetDamage(demon, damagePattern, additionalActionPattern);

                if (!demonsInfo.ContainsKey(demon))
                {
                    demonsInfo.Add(demon, new List<double>());
                    demonsInfo[demon].Add(health);
                    demonsInfo[demon].Add(damage);
                }
            }

            foreach (KeyValuePair<string, List<double>> demon in demonsInfo.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }

        static double GetDamage(string demon, string damagePattern, string additionalActionPattern)
        {
            MatchCollection damage = Regex.Matches(demon, damagePattern);
            MatchCollection additionalactions = Regex.Matches(demon, additionalActionPattern);

            double totalDamage = 0.0;
            
            if (damage.Count > 0)
            {
                foreach (Match digit in damage)
                {
                    totalDamage += double.Parse(digit.Value);
                }

                if (additionalactions.Count > 0)
                {
                    foreach (Match operation in additionalactions)
                    {
                        if (operation.Value == "*")
                        {
                            totalDamage *= 2;
                        }
                        else if (operation.Value == "/")
                        {
                            if (totalDamage != 0)
                            {
                                totalDamage /= 2;
                            }
                        }
                    }
                }
            }

            return totalDamage;
        }

        static double GetHealth(string demon, string pattern)
        {
            MatchCollection health = Regex.Matches(demon, pattern);

            double totalhealth = 0;

            if (health.Count > 0)
            {
                foreach (Match item in health)
                {
                    char character = char.Parse(item.Value);

                    totalhealth += character;
                }
            }

            return totalhealth;
        }
    }
}
