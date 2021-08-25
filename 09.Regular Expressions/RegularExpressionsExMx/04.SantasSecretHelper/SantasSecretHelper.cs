using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.SantasSecretHelper
{
    class SantasSecretHelper
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();

            string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behavior>[GN])!";

            List<string> goodChildren = new List<string>();

            while (message != "end")
            {
                StringBuilder decryptedMessage = new StringBuilder();

                foreach (char charecter in message)
                {
                    decryptedMessage.Append((char)(charecter - key));
                }

                Match child = Regex.Match(decryptedMessage.ToString(), pattern);

                if (child.Groups["behavior"].Value == "G")
                {
                    goodChildren.Add(child.Groups["name"].Value);
                }

                message = Console.ReadLine();
            }

            foreach (string child in goodChildren)
            {
                Console.WriteLine(child);
            }
        }
    }
}
