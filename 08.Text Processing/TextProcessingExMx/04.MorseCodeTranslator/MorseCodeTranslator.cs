using System;
using System.Collections.Generic;
using System.Text;

namespace _04.MorseCodeTranslator
{
    class MorseCodeTranslator
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> code = new Dictionary<string, string>()
            {
                {"A",".-" },{"B","-..." }, {"C","-.-." },{"D","-.." },{"E","." },{"F","..-." },
                {"G","--." }, {"H","...." }, {"I",".." },{"J",".---" },{"K","-.-" }, {"L",".-.." },
                {"M","--" }, {"N","-." },{"O","---" },{"P",".--." },{"Q","--.-" }, {"R",".-." },
                {"S","..." },{"T","-" },{"U","..-" }, {"V","...-" }, {"W",".--" }, {"X","-..-" },
                {"Y","-.--" },{"Z","--.." },
            };

            StringBuilder decodedmessage = new StringBuilder();

            string[] message = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in message)
            {
                foreach (KeyValuePair<string, string> letter in code)
                {
                    if (word == "|")
                    {
                        decodedmessage.Append(word);
                        break;
                    }
                    else if (word == letter.Value)
                    {
                        decodedmessage.Append(letter.Key);
                        break;
                    }
                }
            }

            string finalMessage = decodedmessage.ToString().Replace("|", " ");
            Console.WriteLine(finalMessage);
        }
    }
}
