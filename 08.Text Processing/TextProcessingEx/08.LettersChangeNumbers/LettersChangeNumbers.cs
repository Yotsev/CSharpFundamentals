using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0.0;

            foreach (string item in input)
            {

                char firstletter = item[0];
                char lastletter = item[item.Length - 1];
                double number = double.Parse(item.Substring(1, item.Length - 2));

                if (char.IsUpper(firstletter))
                {
                     number /= firstletter - 64;
                }
                else
                {
                    number *= firstletter - 96;
                }
                
                if (char.IsUpper(lastletter))
                {
                    number -=  lastletter - 64;
                }
                else
                {
                    number += lastletter - 96;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
