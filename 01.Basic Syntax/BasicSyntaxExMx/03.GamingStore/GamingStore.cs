using System;

namespace _03.GamingStore
{
    class GamingStore
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string commnad = Console.ReadLine();
            string game = string.Empty;
            double amountSpend = 0;
            double price = 0;

            while (commnad != "Game Time")
            {
                if (commnad == "OutFall 4")
                {
                    game = "OutFall 4";
                    price = 39.99;
                }
                else if (commnad == "CS: OG")
                {
                    game = "CS: OG";
                    price = 15.99;
                }
                else if (commnad == "Zplinter Zell")
                {
                    game = "Zplinter Zell";
                    price = 19.99;
                }
                else if (commnad == "Honored 2")
                {
                    game = "Honored 2";
                    price = 59.99;
                }
                else if (commnad == "RoverWatch")
                {
                    game = "RoverWatch";
                    price = 29.99;
                }
                else if (commnad == "RoverWatch Origins Edition")
                {
                    game = "RoverWatch Origins Edition";
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    commnad = Console.ReadLine();
                    continue;
                }

                if (price <= balance)
                {
                    Console.WriteLine($"Bought {game}");
                    balance -= price;
                    amountSpend += price;
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                commnad = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${amountSpend:f2}. Remaining: ${balance:f2}");
        }
    }
}
