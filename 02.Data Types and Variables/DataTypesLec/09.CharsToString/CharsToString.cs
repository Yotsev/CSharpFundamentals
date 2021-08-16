using System;

namespace _09.CharsToString
{
    class CharsToString
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            string concat = firstChar.ToString() + secondChar.ToString() + thirdChar.ToString();

            Console.WriteLine(concat);
        }
    }
}
