using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>[0-9]{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";

            Regex regex = new Regex(pattern);

            string dates = Console.ReadLine();

            MatchCollection matchDates = regex.Matches(dates);

            foreach (Match date in matchDates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
