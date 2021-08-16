using System;

namespace _02.FromLeftToTheRight
{
    class FromLeftToTheRight
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string numbers = Console.ReadLine();

                string[] nums = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                long firstNumber = long.Parse(nums[0]);
                long secondNumber = long.Parse(nums[1]);
                long sum = 0;

                if (firstNumber > secondNumber)
                {
                    while (firstNumber != 0)
                    {
                        sum += firstNumber % 10;
                        firstNumber = firstNumber / 10;
                    }
                }
                else
                {
                    while (secondNumber != 0)
                    {
                        sum += secondNumber % 10;
                        secondNumber = secondNumber / 10;
                    }
                }
                
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
