using System;
using System.Linq;

namespace _05.WordFilter
{
    class WordFilter
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
