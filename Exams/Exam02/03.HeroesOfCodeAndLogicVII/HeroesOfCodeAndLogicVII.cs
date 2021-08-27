using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogicVII
{
    class HeroesOfCodeAndLogicVII
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] hero = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string heroName = hero[0];
                int heroHP = int.Parse(hero[1]);
                int hetoMP = int.Parse(hero[2]);

                if (!heroes.ContainsKey(heroName))
                {
                    heroes.Add(heroName, new List<int>());
                    heroes[heroName].Add(heroHP);
                    heroes[heroName].Add(hetoMP);
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "CastSpell")
                {
                    string heroName = commandArgs[1];
                    int manaNeeded = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    if (heroes[heroName][1] >= manaNeeded)
                    {
                        heroes[heroName][1] -= manaNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    string heroName = commandArgs[1];
                    int damage = int.Parse(commandArgs[2]);
                    string attacker = commandArgs[3];
                    
                    heroes[heroName][0] -= damage;

                    if (heroes[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (action == "Recharge")
                {
                    string heroName = commandArgs[1];
                    int amont = int.Parse(commandArgs[2]);

                    int currentMP = heroes[heroName][1];
                    heroes[heroName][1] += amont;

                    if (heroes[heroName][1] > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - currentMP} MP!");
                        heroes[heroName][1] = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amont} MP!");
                    }
                }
                else if (action == "Heal")
                {
                    string heroName = commandArgs[1];
                    int amont = int.Parse(commandArgs[2]);

                    int currentHP = heroes[heroName][0];
                    heroes[heroName][0] += amont;

                    if (heroes[heroName][0] > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - currentHP} HP!");
                        heroes[heroName][0] = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amont} HP!");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var hero in heroes.OrderByDescending(h => h.Value[0]).ThenBy(n => n.Key))
            {
                if (hero.Value[0] > 0)
                {
                    Console.WriteLine(hero.Key);
                    Console.WriteLine($"HP: {hero.Value[0]}");
                    Console.WriteLine($"MP: {hero.Value[1]}");
                }
            }
        }
    }
}
