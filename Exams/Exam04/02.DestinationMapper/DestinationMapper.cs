using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02.DestinationMapper
{
    class DestinationMapper
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();

            string validPlacesPattern = @"(=|\/)(?<place>[A-Z][A-Za-z]{2,})(\1)";

            MatchCollection validPlaces = Regex.Matches(places, validPlacesPattern);

            int travelPoint = 0;

            List<string> placesToPrint = new List<string>();

            foreach (Match place in validPlaces)
            {
                travelPoint += place.Groups["place"].Value.Length;
                placesToPrint.Add(place.Groups["place"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", placesToPrint)}");
            Console.WriteLine($"Travel Points: {travelPoint}");
        }
    }
}
