using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04.StarEnigma
{
    class StarEnigma
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            string keyPattern = @"[star]";
            string targetPattern = @"@(?<planet>[A-Za-z]+)(?:[^@\-!:>]*)?:(?:\d+)(?:[^@\-!:>]*)?!(?<attacktype>[AD])!(?:[^@\-!:>]*)?->(?:\d+)";

            Regex key = new Regex(keyPattern);
            Regex target = new Regex(targetPattern);

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();

                string decryptedMessage = MessageDecruption(key, message);

                Attack(target, decryptedMessage, attackedPlanets, destroyedPlanets);
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (string planet in attackedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (string planet in destroyedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
        static void Attack(Regex target, string decryptedMessage, List<string> attacked, List<string> destroyed)
        {
            Match attackInfo = target.Match(decryptedMessage);

            if (attackInfo.Success)
            {
                string planetName = attackInfo.Groups["planet"].Value;
                char attackType = char.Parse(attackInfo.Groups["attacktype"].Value);

                if (attackType == 'A')
                {
                    attacked.Add(planetName);
                }
                else if (attackType == 'D')
                {
                    destroyed.Add(planetName);
                }
            }
        }

        static string MessageDecruption(Regex key, string message)
        {
            string caseInsensitiveMessage = message.ToLower();

            MatchCollection matchedLetters = key.Matches(caseInsensitiveMessage);

            int count = matchedLetters.Count;

            string decryptedMessage = string.Empty;

            for (int j = 0; j < caseInsensitiveMessage.Length; j++)
            {
                decryptedMessage += (char)(message[j] - count);
            }

            return decryptedMessage;
        }
    }
}
