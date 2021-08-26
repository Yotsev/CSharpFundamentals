using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ManOWar
{
    class ManOWar
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] warship = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int maximumHealthCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            bool isStalemate = true;

            while (command != "Retire")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Fire")
                {
                    int index = int.Parse(commandArgs[1]);
                    int damage = int.Parse(commandArgs[2]);

                    if (index>= 0 && warship.Length> index)
                    {
                        warship[index] -= damage;
                        if (warship[index]<= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isStalemate = false;
                            break;
                        }
                    }
                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int damage = int.Parse(commandArgs[3]);

                    if (startIndex>=0 && endIndex>=0 && pirateShip.Length>endIndex && pirateShip.Length>startIndex)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i]<=0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isStalemate = false;
                                break;
                            }
                        }
                    }
                    if (!isStalemate)
                    {
                        break;
                    }
                }
                else if (action == "Repair")
                {
                    int index = int.Parse(commandArgs[1]);
                    int health = int.Parse(commandArgs[2]);

                    if (index>=0 && pirateShip.Length>index)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > maximumHealthCapacity)
                        {
                            pirateShip[index] = maximumHealthCapacity;
                        }
                    }
                }
                else if (action == "Status")
                {
                    int numberOfSections = 0;
                    for (int i = 0; i < pirateShip.Length; i++)
                    {
                        if (pirateShip[i] < maximumHealthCapacity*0.2)
                        {
                            numberOfSections++;
                        }
                    }
                    Console.WriteLine($"{numberOfSections} sections need repair.");
                }

                command = Console.ReadLine();
            }

            if (isStalemate)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warship.Sum()}");
            }
        }
    }
}
