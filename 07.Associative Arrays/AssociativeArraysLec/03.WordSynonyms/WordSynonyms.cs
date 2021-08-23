using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordSynonyms
{
    class WordSynonyms
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (words.ContainsKey(word))
                {
                    words[word].Add(synonym);
                }
                else
                {
                    words.Add(word, new List<string>());
                    words[word].Add(synonym);
                }
            }

            foreach (KeyValuePair<string, List<string>> word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}
