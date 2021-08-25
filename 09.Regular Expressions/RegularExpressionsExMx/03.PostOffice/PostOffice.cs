using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _03.PostOffice
{
    class PostOffice
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            string firstPart = input[0];
            string secondPart = input[1];
            string[] thirdPartt = input[2]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstPartPattern = @"([#$%*&])(?<capitalLetters>[A-Z]+)\1";
            string secondPartPattern = @"(?<letter>[0-9]+):(?<length>[0-9]{2})";

            Match capittalLetters = Regex.Match(firstPart, firstPartPattern);
            MatchCollection startingLetterAndLenght = Regex.Matches(secondPart, secondPartPattern);

            List<string> words = new List<string>();

            foreach (Match startingLetter in startingLetterAndLenght)
            {
                foreach (char letter in capittalLetters.Groups["capitalLetters"].Value)
                {
                    if ((char)(int.Parse(startingLetter.Groups["letter"].Value)) == letter)
                    {
                        foreach (string word in thirdPartt)
                        {
                            if (word[0] == letter && word.Length == int.Parse(startingLetter.Groups["length"].Value) + 1)
                            {
                                if (words.Contains(word))
                                {
                                    words.Remove(word);
                                }
                                words.Add(word);
                            }
                        }
                    }
                }
            }

            foreach (string word in words)
            {
                if (word.Length <= 20)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}

//string[] input = Console.ReadLine().Split("|");
//string patternCapitals = @"([#$%*&])(?<capitals>[A-Z]+)\1";
//Match capitalsMatch = Regex.Match(input[0], patternCapitals);
//Dictionary<char, int> capitalDictionary = new Dictionary<char, int>();
//string capitals = capitalsMatch.Groups["capitals"].Value;
//for (int i = 0; i < capitals.Length; i++)
//{
//    char capitalLetter = capitals[i];
//    int ascii = capitalLetter;
//    string patternWordLength = $@"{ascii}:(?<length>[0-9][0-9])";
//    Match wordLengthMatch = Regex.Match(input[1], patternWordLength);
//    int length = int.Parse(wordLengthMatch.Groups["length"].Value) >= 20 ?
//        int.Parse(wordLengthMatch.NextMatch().Groups["length"].Value) : int.Parse(wordLengthMatch.Groups["length"].Value);
//    string patternWords = $@"(?<=\s|^){capitalLetter}[^\s]{{{length}}}(?=\s|$)";
//    Match word = Regex.Match(input[2], patternWords);
//    string strWord = word.ToString();
//    Console.WriteLine(strWord);
