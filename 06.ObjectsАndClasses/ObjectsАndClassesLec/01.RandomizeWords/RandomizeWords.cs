using System;

namespace _01.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int pos = rnd.Next(words.Length);
                string tempWord = words[i];

                words[i] = words[pos];
                words[pos] = tempWord;
            }

            Console.Write(string.Join("\n", words));
        }
    }
}
