using System;

namespace _02.VowelsCount
{
    class VowelsCount
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int result = Vowels(word);

            Console.WriteLine(result);
        }
        static int Vowels(string word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' ||
                    word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
