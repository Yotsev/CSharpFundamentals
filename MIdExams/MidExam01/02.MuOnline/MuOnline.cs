using System;

namespace _02.MuOnline
{
    class MuOnline
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            int maxHealth = 100;
            int currentHealth = maxHealth;
            int bitcoins = 0;
            bool isAlive = true;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] roomArgs = rooms[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = roomArgs[0];
                int number = int.Parse(roomArgs[1]);

                if (command == "potion")
                {

                    if (currentHealth+number > 100)
                    {
                        Console.WriteLine($"You healed for {maxHealth-currentHealth} hp.");
                        currentHealth = maxHealth;
                        Console.WriteLine($"Current health: {currentHealth} hp.");
                    }
                    else
                    {
                        currentHealth += number;
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {currentHealth} hp.");
                    }
                }
                else if (command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    currentHealth -= number;
                    
                    if (currentHealth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        isAlive = false;
                        break;
                    }
                }
            }
            if (isAlive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {currentHealth}");
            }
        }
    }
}
