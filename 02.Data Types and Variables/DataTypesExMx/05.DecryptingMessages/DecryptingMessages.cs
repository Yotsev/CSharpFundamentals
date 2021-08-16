using System;

namespace _05.DecryptingMessages
{
    class DecryptingMessages
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            string text = string.Empty;

            for (int i = 1; i <= numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int correctLetter = letter + key;
                text += (char)correctLetter;
            }
            Console.WriteLine(text);
        }
    }
}
