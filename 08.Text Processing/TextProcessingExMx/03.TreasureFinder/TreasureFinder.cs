using System;
using System.Linq;
using System.Text;

namespace _03.TreasureFinder
{
    class TreasureFinder
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();

            StringBuilder message = new StringBuilder();

            while (input != "find")
            {
                int keyIndex = 0;
                
                for (int i = 0; i < input.Length; i++)
                {
                    if (keyIndex>keys.Length-1)
                    {
                        keyIndex = 0;
                    }

                    message.Append((char)(input[i] - keys[keyIndex]));
                    keyIndex++;
                }

                int firstIndexOfTreasure = message.ToString().IndexOf('&')+1;
                int lastIndexOfTreasure = message.ToString().LastIndexOf('&');
                string treasure = message.ToString().Substring(firstIndexOfTreasure, lastIndexOfTreasure - firstIndexOfTreasure);

                int firstIndexOfcoordinates = message.ToString().IndexOf('<') + 1;
                int lastIndexOfcoordinates = message.ToString().IndexOf('>');
                string coordinates = message.ToString().Substring(firstIndexOfcoordinates, lastIndexOfcoordinates - firstIndexOfcoordinates);

                Console.WriteLine($"Found {treasure} at {coordinates}");
                message.Clear();

                input = Console.ReadLine();
            }
        }
    }
}
