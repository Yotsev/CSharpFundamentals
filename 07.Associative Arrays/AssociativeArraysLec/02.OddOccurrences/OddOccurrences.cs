using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount.Add(word, 1);
                }
            }

            foreach (KeyValuePair<string, int> word in wordsCount)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
