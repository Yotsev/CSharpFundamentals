using System;
using System.Text;
using System.Linq;

namespace _05.MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplayer = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplayNumbers(number, multiplayer));
            
        }
        static string MultiplayNumbers(string number, int multiplayer)
        {
            int reminder = 0;

            if (multiplayer == 0)
            {
                return "0";
            }

            StringBuilder result = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';

                reminder += multiplayer * digit;

                if (reminder > 9)
                {
                    int reminderLastDigit = reminder % 10;
                    reminder /= 10;

                    result.Append(reminderLastDigit.ToString());
                }
                else
                {
                    result.Append(reminder.ToString());
                    reminder = 0;
                }
            }

            if (reminder > 0)
            {
                result.Append(reminder.ToString());
            }

            return string.Concat(result.ToString().Reverse());
        }
    }
}
