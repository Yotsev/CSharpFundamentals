using System;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class FancyBarcodes
    {
        static void Main(string[] args)
        {
            int numberOfBarcodes = int.Parse(Console.ReadLine());

            string barcoCodePattern = @"(@#+)(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)";
            string digitsPattern = @"\d";

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                string input = Console.ReadLine();

                Match barcode = Regex.Match(input, barcoCodePattern);

                if (barcode.Success)
                {
                    MatchCollection group = Regex.Matches(barcode.Groups["product"].Value, digitsPattern);

                    if (group.Count>0)
                    {
                        string itemGroup = string.Empty;
                        foreach (var item in group)
                        {
                            char digit = char.Parse(item.ToString());
                            itemGroup += digit;
                        }

                        Console.WriteLine($"Product group: {itemGroup}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
