using System;
using System.Text;

namespace _03.CharactersInRange
{
    class CharactersInRange
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string result = RangeOfCharecters(firstChar, secondChar);

            Console.WriteLine(result.TrimEnd());
        }

        static string RangeOfCharecters (char firstChar, char SecondChar)
        {
            StringBuilder range = new StringBuilder();

            int startChar = Math.Min(firstChar, SecondChar);
            int endChar = Math.Max(firstChar, SecondChar);

            for (int i = startChar+1; i < endChar; i++)
            {
                range.Append((char)i).Append(" ");
            }

            return range.ToString();
        }
    }
}
