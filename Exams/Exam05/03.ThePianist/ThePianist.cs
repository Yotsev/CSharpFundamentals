using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThePianist
{
    class ThePianist
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieceInfo = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string pieceName = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];

                if (!pieces.ContainsKey(pieceName))
                {
                    pieces.Add(pieceName, new Piece(pieceName, composer, key));
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                string pieceName = commandArgs[1];

                if (action == "Add")
                {
                    string composer = commandArgs[2];
                    string key = commandArgs[3];
                    
                    if (!pieces.ContainsKey(pieceName))
                    {
                        pieces.Add(pieceName, new Piece(pieceName, composer, key));
                        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    if (!pieces.ContainsKey(pieceName))
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                    else
                    {
                        pieces.Remove(pieceName);
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                }
                else if (action == "ChangeKey")
                {
                    string key = commandArgs[2];

                    if (!pieces.ContainsKey(pieceName))
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                    else
                    {
                        pieces[pieceName].Key = key;
                        Console.WriteLine($"Changed the key of {pieceName} to {key}!");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var piece in pieces.OrderBy(n => n.Value.Name).ThenBy(c => c.Value.Composer))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }
    }

    class Piece
    {
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
