using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());

            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = input[0];
                string name = input[1];
                int damage;
                bool damageSuccess = Int32.TryParse(input[2], out damage);
                int health;
                bool healthSuccess = Int32.TryParse(input[3], out health);
                int armor;
                bool armorSuccess = Int32.TryParse(input[4], out armor);

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new List<Dragon>());
                    dragons[type].Add(new Dragon(type, name));

                    Dragon existingDragon = GetDragon(dragons, type, name);
                    AddingStats(damage, health, armor, damageSuccess, healthSuccess, armorSuccess, existingDragon);
                }
                else
                {
                    Dragon existingDragon = GetDragon(dragons, type, name);
                    
                    if (existingDragon == null)
                    {
                        dragons[type].Add(new Dragon(type, name));
                        Dragon newDragon = GetDragon(dragons, type, name);
                        AddingStats(damage, health, armor, damageSuccess, healthSuccess, armorSuccess, newDragon);
                    }
                    else
                    {
                        if (existingDragon.Name == name && existingDragon.Type == type)
                        {
                            AddingStats(damage, health, armor, damageSuccess, healthSuccess, armorSuccess, existingDragon);
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, List<Dragon>> typeOfDragon in dragons)
            {
                List<double> avgStats = GetAvgStats(dragons, typeOfDragon.Key);

                Console.WriteLine($"{typeOfDragon.Key}::({avgStats[0]:f2}/{avgStats[1]:f2}/{avgStats[2]:f2})");
                
                List<Dragon> ordaredDragons = typeOfDragon.Value.OrderBy(d => d.Name).ToList();

                foreach (var dragon in ordaredDragons)
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }

        static List<double> GetAvgStats(Dictionary<string, List<Dragon>> dragons, string type)
        {
            List<double> avgStats = new List<double>();

            int cout = dragons[type].Count;
            double totalDamage = 0.0;
            double totalHealth = 0.0;
            double totalArmor = 0.0;

            foreach (Dragon dragon in dragons[type])
            {
                totalDamage += dragon.Damage;
                totalHealth += dragon.Health;
                totalArmor += dragon.Armor;
            }

            avgStats.Add(totalDamage / cout);
            avgStats.Add(totalHealth / cout);
            avgStats.Add(totalArmor / cout);

            return avgStats;
        }

        static void AddingStats(int damage, int health, int armor, bool damageSuccess, bool healthSuccess, bool armorSuccess, Dragon existingDragon)
        {
            if (damageSuccess)
            {
                existingDragon.Damage = damage;
            }
            else
            {
                 existingDragon.Damage = 45;
            }
            if (healthSuccess)
            {
                existingDragon.Health = health;
            }
            else
            {
                existingDragon.Health = 250;
            }
            if (armorSuccess)
            {
                existingDragon.Armor = armor;
            }
            else
            {
                existingDragon.Armor = 10;
            }
        }

        private static Dragon GetDragon(Dictionary<string, List<Dragon>> dragons, string type, string name)
        {
            foreach (KeyValuePair<string, List<Dragon>> typeOfDragon in dragons)
            {
                if (typeOfDragon.Key == type)
                {
                    foreach (Dragon item in typeOfDragon.Value)
                    {
                        if (item.Name == name)
                        {
                            return item;
                        }
                    }
                }
            }

            return null;
        }
    }

    class Dragon
    {

        public Dragon(string type, string name)
        {
            Type = type;
            Name = name;
        }
        public string Type { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; } = 45;

        public int Health { get; set; } = 250;

        public int Armor { get; set; } = 10;
    }
}
