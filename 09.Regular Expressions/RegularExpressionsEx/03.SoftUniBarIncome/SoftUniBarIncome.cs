using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _03.SoftUniBarIncome
{
    class SoftUniBarIncome
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string pattern = @"%(?<name>[A-Z][a-z]+)%(?:[^|$%.]*)?<(?<product>\w+)>(?:[^|$%.]*)?\|(?<quantity>\d+)\|(?:[^|$%.]*?)??(?<price>\d+\.?\d*)\$";

            Regex regex = new Regex(pattern);

            decimal totalIncome = 0.0m;

            while (command != "end of shift")
            {
                Match machedLine = regex.Match(command);

                if (machedLine.Success)
                {
                    string name = machedLine.Groups["name"].Value;
                    string product = machedLine.Groups["product"].Value;
                    int quantity = int.Parse(machedLine.Groups["quantity"].Value);
                    decimal price = decimal.Parse(machedLine.Groups["price"].Value);
                    decimal totalPrice = price * quantity;

                    totalIncome += totalPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
