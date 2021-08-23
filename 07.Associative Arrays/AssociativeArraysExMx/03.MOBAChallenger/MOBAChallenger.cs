using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBAChallenger
{
    class MOBAChallenger
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Season end")
            {
                string separator = string.Empty;

                if (input.Contains(" -> "))
                {
                    separator = " -> ";
                    string[] inputArgs = input
                        .Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    string playerName = inputArgs[0];
                    string playerPosition = inputArgs[1];
                    int playerSkill = int.Parse(inputArgs[2]);

                    if (!playerPool.ContainsKey(playerName))
                    {
                        playerPool.Add(playerName, new Dictionary<string, int>());
                        playerPool[playerName].Add(playerPosition, playerSkill);
                    }
                    else
                    {
                        if (playerPool[playerName].ContainsKey(playerPosition))
                        {
                            if (playerPool[playerName][playerPosition] < playerSkill)
                            {
                                playerPool[playerName][playerPosition] = playerSkill;
                            }
                        }
                        else
                        {
                            playerPool[playerName].Add(playerPosition, playerSkill);
                        }
                    }
                }
                else
                {
                    separator = " vs ";
                    string[] inputArgs = input
                        .Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    string firstPlayer = inputArgs[0];
                    string secondPlayer = inputArgs[1];

                    if (playerPool.ContainsKey(firstPlayer) && playerPool.ContainsKey(secondPlayer))
                    {
                        Fight(playerPool, firstPlayer, secondPlayer);
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> playersTotalSkill = new Dictionary<string, int>();

            foreach (var player in playerPool)
            {
                int totalSkill = GetPlayerTotalSkill(playerPool, player.Key);
                if (totalSkill > 0)
                {
                    playersTotalSkill.Add(player.Key, totalSkill);
                }
            }

            foreach (var player in playersTotalSkill.OrderByDescending(s => s.Value).ThenBy(n  => n.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                foreach (var person in playerPool)
                {
                    if (player.Key == person.Key)
                    {
                        foreach (var positon in playerPool[player.Key].OrderByDescending(s => s.Value).ThenBy(n => n.Key))
                        {
                            Console.WriteLine($"- {positon.Key} <::> {positon.Value}");
                        }
                    }
                }
            }
        }

        static void Fight(Dictionary<string, Dictionary<string, int>> playerPool, string firstPlayer, string secondPlayer)
        {
            int firstPlayerTotalSkill = GetPlayerTotalSkill(playerPool, firstPlayer);
            int secondPlayerTotalSkill = GetPlayerTotalSkill(playerPool, secondPlayer);

            foreach (KeyValuePair<string, int> first in playerPool[firstPlayer])
            {
                foreach (KeyValuePair<string, int> second in playerPool[secondPlayer])
                {
                    if (first.Key == second.Key)
                    {
                        if (firstPlayerTotalSkill > secondPlayerTotalSkill)
                        {
                            secondPlayerTotalSkill -= second.Value;
                            playerPool[secondPlayer].Remove(second.Key);
                        }
                        else if (secondPlayerTotalSkill > firstPlayerTotalSkill)
                        {
                            firstPlayerTotalSkill -= first.Value;
                            playerPool[firstPlayer].Remove(first.Key);
                        }
                    }
                }
            }
        }

        static int GetPlayerTotalSkill(Dictionary<string, Dictionary<string, int>> playerPool, string playerName)
        {
            int totalSkill = 0;
            foreach (KeyValuePair<string, Dictionary<string, int>> players in playerPool)
            {
                foreach (KeyValuePair<string, int> player in players.Value)
                {
                    if (players.Key == playerName)
                    {
                        totalSkill += player.Value;
                    }
                }
            }

            return totalSkill;
        }
    }
}

