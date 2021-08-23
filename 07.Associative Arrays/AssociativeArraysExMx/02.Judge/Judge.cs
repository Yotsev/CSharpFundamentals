using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Judge
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            int row = 1;
            while (command != "no more time")
            {
                string[] commandArgs = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string userName = commandArgs[0];
                string contest = commandArgs[1];
                int points = int.Parse(commandArgs[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest].Add(userName, points);
                }
                else
                {
                    if (contests[contest].ContainsKey(userName))
                    {
                        if (contests[contest][userName] < points)
                        {
                            contests[contest][userName] = points;
                        }
                    }
                    else
                    {
                        contests[contest].Add(userName, points);
                    }
                }

                command = Console.ReadLine();
            }

            Dictionary<string, int> userPoints = new Dictionary<string, int>();

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                row = 1;
                foreach (var user in contest.Value.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
                {
                    if (userPoints.ContainsKey(user.Key))
                    {
                        userPoints[user.Key] += user.Value;
                    }
                    else
                    {
                        userPoints.Add(user.Key, user.Value);
                    }
                    Console.WriteLine($"{row}. {user.Key} <::> {user.Value}");
                    row++;
                }
            }
            Console.WriteLine("Individual standings:");

            row = 1;
            foreach (var user in userPoints.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{row}. {user.Key} -> {user.Value}");
                row++;
            }
        }
    }
}
