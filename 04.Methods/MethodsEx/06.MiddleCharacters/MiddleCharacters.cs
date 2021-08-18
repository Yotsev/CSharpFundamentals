using System;
using System.Text;

namespace _06.MiddleCharacters
{
    class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string result = MidChar(text);

            Console.WriteLine(result);
        }

        static string MidChar(string text)
        {
            string middleChars = string.Empty;

            if (text.Length % 2 == 0)
            {
                for (int i = text.Length / 2 - 1; i <= text.Length / 2; i++)
                {
                    middleChars += text[i];
                }
            }
            else
            {
                middleChars += text[text.Length / 2];
            }

            return middleChars;
        }
    }
}
