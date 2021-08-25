using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01.Furniture
{
    class Furniture
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @">>(?<product>[A-z\s]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            Regex regex = new Regex(pattern);

            double totalSum = 0.0;

            List<string> items = new List<string>();

            while (input != "Purchase")
            {
                double totalPrice = 0.0;

                Match matchedItem = regex.Match(input);

                if (matchedItem.Success)
                {
                    string name = matchedItem.Groups["product"].Value;
                    double price = double.Parse(matchedItem.Groups["price"].Value);
                    int quantity = int.Parse(matchedItem.Groups["quantity"].Value);

                    totalPrice = price * quantity;
                    
                        items.Add(name);

                    totalSum += totalPrice;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            if (items.Count > 0)
            {
                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
