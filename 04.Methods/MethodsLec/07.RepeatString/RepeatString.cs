using System;
using System.Text;

namespace _07.RepeatString
{
    class RepeatString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            string finalText = RepeatedString(text, repeat);

            Console.WriteLine(finalText);
        }

        static string RepeatedString (string text, int repeats)
        {
            StringBuilder finalstring = new StringBuilder();

            for (int i = 1; i <= repeats; i++)
            {
                finalstring.Append(text);
            }
            return finalstring.ToString();
        }
    }
}
