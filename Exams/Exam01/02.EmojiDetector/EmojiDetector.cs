using System;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class EmojiDetector
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emojiPattern = @"(::|\*\*)(?<emote>[A-Z]{1}[a-z]{2,})(\1)";
            string thresholdPattern = @"\d";

            MatchCollection thresholdNumbers = Regex.Matches(input, thresholdPattern);

            int threshold = 1;

            foreach (Match num in thresholdNumbers)
            {
                threshold *= int.Parse(num.Value);
            }

            MatchCollection emojies = Regex.Matches(input, emojiPattern);

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");
            
            foreach (Match emoji in emojies)
            {
                int emojiCoolnes = 0;

                foreach (char symbol in emoji.Groups["emote"].Value)
                {
                    emojiCoolnes += symbol;
                }

                if (emojiCoolnes >= threshold)
                {
                    Console.WriteLine(emoji.Value);
                }
            }
        }
    }
}
