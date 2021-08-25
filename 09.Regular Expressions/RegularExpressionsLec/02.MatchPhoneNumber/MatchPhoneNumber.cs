using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();

            string pattern = @"(?:^|\s)\+[359]{3}(\s|-)[2]\1[0-9]{3}\1[0-9]{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(phoneNumbers);

            string[] matchedPhones = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
