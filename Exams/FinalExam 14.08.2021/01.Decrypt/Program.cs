using System;
using System.Text;

namespace _01.Decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            StringBuilder decrypted = new StringBuilder(input);

            while (command != "Finish")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "Replace")
                {
                    string oldChar = commandArgs[1];
                    string newChar = commandArgs[2];

                    decrypted = decrypted.Replace(oldChar, newChar);

                    Console.WriteLine(decrypted);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (startIndex<0 
                        || startIndex>=decrypted.Length 
                        || endIndex<0 
                        || endIndex>=decrypted.Length)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                        decrypted.Remove(startIndex, (endIndex - startIndex)+1);

                        Console.WriteLine(decrypted);
                    }
                }
                else if (action == "Make")
                {
                    string casing = commandArgs[1];
                    string message = decrypted.ToString();

                    if (casing == "Upper")
                    {
                        decrypted = decrypted.Replace(message, message.ToUpper());
                    }
                    else
                    {
                        decrypted = decrypted.Replace(message, message.ToLower());
                    }

                    Console.WriteLine(decrypted);
                }
                else if (action == "Check")
                {
                    string substring = commandArgs[1];

                    if (decrypted.ToString().Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }
                }
                else if (action == "Sum")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    int sum = 0;
                    
                    if (startIndex < 0
                        || startIndex >= decrypted.Length
                        || endIndex < 0
                        || endIndex >= decrypted.Length)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                        string substring = decrypted.ToString().Substring(startIndex, (endIndex - startIndex) + 1);

                        foreach (char letter in substring)
                        {
                            sum += letter;
                        }

                        Console.WriteLine(sum);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
