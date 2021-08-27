using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace _02.MirrorWords
{
    class MirrorWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(@|#)(?<firstword>[A-Za-z]{3,})\1\1(?<secondword>[A-Za-z]{3,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> mirrorWords = new List<string>();

            foreach (Match words in matches)
            {
                string firstWord = words.Groups["firstword"].Value;
                string secondWord = words.Groups["secondword"].Value;

                string firstWordReversed = ReverseWord(firstWord);
                string secondWordReversed = ReverseWord(secondWord);

                if (firstWord == secondWordReversed || firstWordReversed == secondWord)
                {
                    mirrorWords.Add(firstWord);
                    mirrorWords.Add(secondWord);
                }
            }

            bool existingMatches = false;

            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                if (mirrorWords.Count == 0)
                {
                    existingMatches = true;
                }
                else
                {
                    StringBuilder bobTheBuilder = new StringBuilder();
                    GetMirrorWordsForOutput(mirrorWords, bobTheBuilder);

                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(bobTheBuilder);
                }
            }
            else
            {
                existingMatches = true;
                Console.WriteLine("No word pairs found!");
            }

            if (existingMatches)
            {
                Console.WriteLine("No mirror words!");
            }
        }

        static void GetMirrorWordsForOutput(List<string> mirrorWords, StringBuilder bobTheBuilder)
        {
            for (int i = 0; i < mirrorWords.Count - 2; i += 2)
            {
                bobTheBuilder.Append(mirrorWords[i]);
                bobTheBuilder.Append(" <=> ");
                bobTheBuilder.Append(mirrorWords[i + 1]);
                bobTheBuilder.Append(", ");
            }
            bobTheBuilder.Append(mirrorWords[mirrorWords.Count - 2]);
            bobTheBuilder.Append(" <=> ");
            bobTheBuilder.Append(mirrorWords[mirrorWords.Count - 1]);
        }

        static string ReverseWord(string text)
        {
            char[] reversed = text.ToCharArray();
            Array.Reverse(reversed);
            return new string(reversed);
        }
    }
}
