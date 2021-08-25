using System;
using System.Text.RegularExpressions;

namespace _01.WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // string valaidTicketPattern = @"\S{20}";
            string valid = @"\S+|\S{20}";
            Regex validTicket = new Regex(valid);

            foreach (string ticket in tickets)
            {
                Match checkTicket = validTicket.Match(ticket);

                if (checkTicket.Length > 20 || checkTicket.Length < 20 || !checkTicket.Success)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string winningTicketPattern = @"(@{6,10}|#{6,10}|\${6,10}|\^{6,10})";

                    Regex winningTicket = new Regex(winningTicketPattern);

                    string leftSide = checkTicket.ToString().Substring(0, checkTicket.Length / 2);
                    string rightSide = checkTicket.ToString().Substring(checkTicket.Length / 2, checkTicket.Length / 2);

                    Match left = winningTicket.Match(leftSide);
                    Match right = winningTicket.Match(rightSide);

                    if (left.Success && right.Success)
                    {
                        if (left.Value == right.Value)
                        {
                            if (left.Length >= 6 && left.Length <= 9)
                            {
                                Console.WriteLine($"ticket \"{checkTicket}\" - {left.Length}{left.Value[0]}");
                            }
                            else if (left.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{checkTicket}\" - {left.Length}{left.Value[0]} Jackpot!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{checkTicket}\" - {Math.Min(left.Length, right.Length)}{left.Value[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{checkTicket}\" - no match");
                    }
                }
            }
        }
    }
}
