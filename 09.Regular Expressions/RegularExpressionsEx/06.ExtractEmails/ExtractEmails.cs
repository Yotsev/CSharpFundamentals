using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))[A-Za-z\d]+([-._][A-Za-z\d]+)*@[A-Za-z]+(\-[A-Za-z]+)*(\.[A-Za-z+]+)+";

            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection machedEmails = regex.Matches(text);

            foreach (Match email in machedEmails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
