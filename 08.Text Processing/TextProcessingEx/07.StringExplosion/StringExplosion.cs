using System;
using System.Text;

namespace _07.StringExplosion
{
    class StringExplosion
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int explosion = 0;

            StringBuilder finalText = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    explosion += input[i + 1] - '0';
                    finalText.Append(input[i]);
                }
                else if (explosion != 0)
                {
                    explosion--;
                }
                else
                {
                    finalText.Append(input[i]);
                }
            }

            Console.WriteLine(finalText);
        }
    }
}
