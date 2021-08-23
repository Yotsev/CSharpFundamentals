using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class CountCharsInAString
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string fullString = string.Empty;

            foreach (string word in words)
            {
                fullString += word;
            }

            Dictionary<char, int> charCout = new Dictionary<char, int>();

            for (int i = 0; i < fullString.Length; i++)
            {
                if (charCout.ContainsKey(fullString[i]))
                {
                    charCout[fullString[i]]++;
                }
                else
                {
                    charCout.Add(fullString[i], 1);
                }
            }

            foreach (KeyValuePair<char, int> character in charCout)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
