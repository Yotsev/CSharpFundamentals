using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class SoftUniExamResults
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> languages = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            List<string> itemToDelete = new List<string>();

            while (input != "exam finished")
            {
                string[] inputArgs = input
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string userName = inputArgs[0];
                string languageOrCommand = inputArgs[1];

                if (languageOrCommand == "banned")
                {
                    foreach (Dictionary<string, int> items in languages.Values)
                    {
                        foreach (var item in items)
                        {
                            if (item.Key == userName)
                            {
                                itemToDelete.Add(item.Key);
                            }
                        }
                    }

                    foreach (string item in itemToDelete)
                    {
                        foreach (Dictionary<string, int> users in languages.Values)
                        {
                            users.Remove(item);
                        }
                    }
                }
                else
                {
                    int userPoints = int.Parse(inputArgs[2]);

                    if (!languages.ContainsKey(languageOrCommand))
                    {
                        languages.Add(languageOrCommand, new Dictionary<string, int>());
                        languages[languageOrCommand].Add(userName, userPoints);
                        submissions.Add(languageOrCommand, 1);
                    }
                    else
                    {
                        if (languages[languageOrCommand].ContainsKey(userName))
                        {
                            if (languages[languageOrCommand][userName] < userPoints)
                            {
                                languages[languageOrCommand][userName] = userPoints;
                                submissions[languageOrCommand]++;
                            }
                            else
                            {
                                submissions[languageOrCommand]++;
                            }
                        }
                        else
                        {
                            languages[languageOrCommand].Add(userName, userPoints);
                            submissions[languageOrCommand]++;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Dictionary<string, int> orderdUsers = new Dictionary<string, int>();

            foreach (Dictionary<string, int> item in languages.Values)
            {
                foreach (var user in item)
                {
                    orderdUsers.Add(user.Key, user.Value);
                }
            }

            Console.WriteLine("Results:");
            foreach (var user in orderdUsers.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in submissions.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
