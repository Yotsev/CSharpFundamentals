using System;
using System.Text;

namespace _02.RepeatStrings
{
    class RepeatStrings
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder bulder = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    bulder.Append(word);
                }
            }

            Console.WriteLine(bulder);
        }
    }
}
