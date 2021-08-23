using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, string> contests = new Dictionary<string, string>();

            while (command != "end of contests")
            {
                string[] commandArgs = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = commandArgs[0];
                string password = commandArgs[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }


                command = Console.ReadLine();
            }

            string newCommand = Console.ReadLine();

            List<User> users = new List<User>();

            while (newCommand != "end of submissions")
            {
                string[] newCommandArgs = newCommand
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = newCommandArgs[0];
                string password = newCommandArgs[1];
                string userName = newCommandArgs[2];
                int points = int.Parse(newCommandArgs[3]);

                object existingContest = GetContest(contest, password, contests);

                if (existingContest != null)
                {
                    User existingUser = GetUser(users, userName);

                    if (existingUser == null)
                    {
                        User user = new User(userName, points);
                        user.Contests.Add(contest, points);
                        users.Add(user);
                    }
                    else
                    {
                        if (existingUser.Contests.ContainsKey(contest))
                        {
                            if (existingUser.Contests[contest] < points)
                            {
                                existingUser.Contests[contest] = points;
                            }
                        }
                        else
                        {
                            existingUser.Contests.Add(contest, points);
                        }
                    }
                }

                newCommand = Console.ReadLine();
            }

            User bestCandidate = GetBestCandidate(users);
            
            Console.WriteLine($"Best candidate is {bestCandidate.Name} with total {bestCandidate.TotalPoints} points.");

            Console.WriteLine("Ranking:");
            foreach (User user in users.OrderBy(n => n.Name))
            {
                Console.WriteLine(user.Name);
                foreach (var contest in user.Contests.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        private static User GetBestCandidate(List<User> users)
        {
            User topUser = null;
            int topScore = 0;
            foreach (User user in users)
            {
                if (topScore < user.TotalPoints)
                {
                    topScore = user.TotalPoints;
                    topUser = user;
                }
            }

            return topUser;
        }

        static User GetUser(List<User> users, string userName)
        {
            foreach (User user in users)
            {
                if (user.Name == userName)
                {
                    return user;
                }
            }

            return null;
        }

        static object GetContest(string contestName, string contestPassword, Dictionary<string, string> contests)
        {
            foreach (var contest in contests)
            {
                if (contest.Key == contestName && contest.Value == contestPassword)
                {
                    return contest;
                }
            }

            return null;
        }
    }
    class Contest
    {
        public Contest(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public string Name { get; set; }

        public string Password { get; set; }

    }

    class User
    {
        public User(string name, int points)
        {
            Name = name;
            Points = points;
            Contests = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public int Points { get; set; }

        public Dictionary<string, int> Contests { get; set; }

        public int TotalPoints
        {
            get
            {
                int totalPoints = 0;

                foreach (KeyValuePair<string, int> contest in Contests)
                {
                    totalPoints += contest.Value;
                }

                return totalPoints;
            }
        }
    }
}
