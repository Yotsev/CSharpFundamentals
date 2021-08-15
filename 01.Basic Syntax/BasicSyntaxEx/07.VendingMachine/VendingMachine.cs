using System;

namespace _07.VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            string commnad = Console.ReadLine();

            double productPrice = 0.0;
            double sum = 0.0;

            while (commnad != "Start")
            {
                double coins = double.Parse(commnad);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1.0 || coins == 2.0)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                commnad = Console.ReadLine();
            }
            commnad = Console.ReadLine();

            while (commnad != "End")
            {
                if (commnad == "Nuts")
                {
                    productPrice = 2.0;
                }
                else if (commnad == "Water")
                {
                    productPrice = 0.7;
                }
                else if (commnad == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (commnad == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (commnad == "Coke")
                {
                    productPrice = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    commnad = Console.ReadLine();
                    continue;
                }
                if (sum >= productPrice)
                {
                    sum -= productPrice;
                    Console.WriteLine($"Purchased {commnad.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                commnad = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
