using System;

namespace _01.TheImitationGame
{
    class TheImitationGame
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandArgs = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "Move")
                {
                    int numberOfLettersToMove = int.Parse(commandArgs[1]);

                    string substring = encryptedMessage.Substring(0, numberOfLettersToMove);
                    encryptedMessage = encryptedMessage.Remove(0, numberOfLettersToMove);
                    encryptedMessage += substring;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string substringToInsert = commandArgs[2];

                    encryptedMessage = encryptedMessage.Insert(index, substringToInsert);
                }
                else if (action == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
