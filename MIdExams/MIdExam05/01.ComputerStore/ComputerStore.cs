using System;

namespace _01.ComputerStore
{
    class ComputerStore
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double tax = 0.2;
            double discount = 0.1;
            double totalTax = 0.0;
            double totalPrce = 0.0;

            while (command != "special" && command != "regular")
            {
                double price = double.Parse(command);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }
                totalPrce += price;
                command = Console.ReadLine();
            }

            totalTax += totalPrce * tax;

            if (totalPrce <= 0)
            {
                Console.WriteLine("Invalid order!");

            }
            else if (command == "special")
            {
                Receipt(totalPrce, totalTax, discount);
            }
            else if (command == "regular")
            {
                Receipt(totalPrce, totalTax);
            }
        }
        static void Receipt(double price, double tax, double discout = 0)
        {
            double totalPriceWithTax = price + tax;
            totalPriceWithTax -= totalPriceWithTax * discout;

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {price:f2}$");
            Console.WriteLine($"Taxes: {tax:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPriceWithTax:f2}$");
        }
    }
}

