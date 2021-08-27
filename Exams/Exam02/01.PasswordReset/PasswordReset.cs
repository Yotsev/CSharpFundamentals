using System;
using System.Text;

namespace _01.PasswordReset
{
    class PasswordReset
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            StringBuilder bobTheBuilder = new StringBuilder();

            while (command != "Done")
            {
                string[] commnadArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commnadArgs[0];

                if (action == "TakeOdd")
                {

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            bobTheBuilder.Append(input[i]);
                        }
                    }

                    input = bobTheBuilder.ToString();
                    bobTheBuilder.Clear();

                    Console.WriteLine(input);
                }
                else if (action == "Cut")
                {
                    int inedex = int.Parse(commnadArgs[1]);
                    int length = int.Parse(commnadArgs[2]);

                    string partToRemove = input.Substring(inedex, length);
                    int startIndex = input.IndexOf(partToRemove);
                    input = input.Remove(startIndex, length);

                    Console.WriteLine(input);

                }
                else
                {
                    string partToSubstitute = commnadArgs[1];
                    string newPart = commnadArgs[2];

                    bool isPresent = input.Contains(partToSubstitute);

                    if (isPresent)
                    {
                        input = input.Replace(partToSubstitute, newPart);

                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
