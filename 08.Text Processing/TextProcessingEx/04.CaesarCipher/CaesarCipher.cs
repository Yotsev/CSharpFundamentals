using System;
using System.Text;

namespace _04.CaesarCipher
{
    class CaesarCipher
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encriptedText = string.Empty;

            foreach (char item in text)
            {
                encriptedText += (char)(item + 3);
            }

            Console.WriteLine(encriptedText);
        }
    }
}
