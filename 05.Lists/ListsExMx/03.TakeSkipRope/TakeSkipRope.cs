using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03.TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> charecters = new List<char>();
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    charecters.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            string result = string.Empty;
            int totalSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                result += new string(charecters.Skip(totalSkip).Take(takeList[i]).ToArray());

                totalSkip += skipList[i] + takeList[i];
            }

            Console.WriteLine(result);
        }
    }
}
