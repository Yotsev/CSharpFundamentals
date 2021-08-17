using System;

namespace _03.ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string[] firstArray = new string[lines];
            string[] secondArray = new string[lines];

            for (int i = 0; i < lines; i++)
            {
                string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (i % 2 == 0)
                {
                    firstArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                    
                }
                else
                {
                    firstArray[i] = numbers[1];
                    secondArray[i] = numbers[0];
                }

            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
