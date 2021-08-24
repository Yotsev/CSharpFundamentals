using System;

namespace _05.DigitsLettersAndOther
{
    class DigitsLettersAndOther
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string chars = string.Empty;
            string digits = string.Empty;
            string other = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits += text[i];
                }
                else if (char.IsLetter(text[i]))
                {
                    chars += text[i];
                }
                else
                {
                    other += text[i];
                }
            }

            Console.WriteLine($"{digits}\n{chars}\n{other}");
        }
    }
}
