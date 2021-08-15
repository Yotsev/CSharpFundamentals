using System;

namespace _05.Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 1; i <= numberOfLetters; i++)
            {
                string letter = Console.ReadLine();
                int numberOfDigits = letter.Length;
                int digit = int.Parse(letter) % 10;
                int offset = 0;
                int index = 0;
                if (digit == 8 || digit == 9)
                {
                    offset = (digit - 2) * 3 + 1;
                }
                else
                {
                    offset = (digit - 2) * 3;
                }
                
                index = (offset + numberOfDigits - 1);
                
                if (digit == 0)
                {
                    message += " ";
                }
                else
                {
                    message += (char)(97 + index);
                }
            }
            Console.WriteLine(message);
        }
    }
}
