using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Messaging
{
    class Messaging
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());

            StringBuilder message = new StringBuilder();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                while (numbers[i]>0)
                {
                    sum += numbers[i] % 10;
                    numbers[i] /= 10;
                }

                int count = 0;

                for (int j = 0; j <= text.Length; j++)
                {
                    if (j==text.Length)
                    {
                        j = 0;
                    }
                    else if (count==sum)
                    {
                        message.Append(text[j]);
                        text.Remove(j,1);
                        sum = 0;
                        break;
                    }
                    count++;
                }
            }

            Console.WriteLine(message);
        }
    }
}
