using System;

namespace _01.ActivationKeys
{
    class ActivationKeys
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {

                string[] commandArgs = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Contains")
                {
                    string substing = commandArgs[1];

                    if (input.Contains(substing))
                    {
                        Console.WriteLine($"{input} contains {substing}");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (action == "Flip")
                {
                    string upperOrLower = commandArgs[1];
                    int startIndex = int.Parse(commandArgs[2]);
                    int endIndex = int.Parse(commandArgs[3]);

                    string symbols = input.Substring(startIndex, endIndex - startIndex);

                    if (upperOrLower == "Upper")
                    {
                        string changedSymbols = symbols.ToUpper();
                        input = input.Replace(symbols, changedSymbols);
                    }
                    else
                    {
                        string changedSymbols = symbols.ToLower();
                        input = input.Replace(symbols, changedSymbols);
                    }

                    Console.WriteLine(input);
                }
                else
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    input = input.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
