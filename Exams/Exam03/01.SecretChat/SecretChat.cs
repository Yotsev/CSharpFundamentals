using System;
using System.Linq;

namespace _01.SecretChat
{
    class SecretChat
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] commandArgs = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "InsertSpace")
                {
                    int index = int.Parse(commandArgs[1]);

                    message = message.Insert(index, " ");
                }
                else if (action == "Reverse")
                {
                    string substring = commandArgs[1];

                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring);
                        message = message.Remove(index, substring.Length);
                        string reversed = Reverse(substring);
                        message = message + reversed;
                    }
                    else
                    {
                        Console.WriteLine("error");

                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    message = message.Replace(substring, replacement);
                }

                Console.WriteLine(message);

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }

        static string Reverse(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
