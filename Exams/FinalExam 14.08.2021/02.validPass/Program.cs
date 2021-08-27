using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.validPass
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"^(.+)>(?<passworditems>[0-9]{3}\|[a-z]{3}\|[A-Z]{3}\|[^<>]{3})<(\1)$";
                StringBuilder password = new StringBuilder();

                Match validPassword = Regex.Match(input, pattern);

                if (validPassword.Success)
                {
                    foreach (char item in validPassword.Groups["passworditems"].Value)
                    {
                        if (item != '|')
                        {
                            password.Append(item);
                        }
                    }

                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
