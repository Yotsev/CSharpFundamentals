using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class ReplaceRepeatingChars
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char letter = '\0';
            
            StringBuilder letters = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (letter != input[i])
                {
                    letters.Append(input[i]);
                }
             
                letter = input[i];
            }

            Console.WriteLine(letters);
        }
    }
}
