using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUserNames = new List<string>();

            foreach (string user in userNames)
            {
                bool isValid = true;

                if (user.Length >= 3 && user.Length <= 16)
                {
                    for (int i = 0; i < user.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(user[i]) && user[i] != '-' && user[i] != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        validUserNames.Add(user);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", validUserNames));
        }
    }
}