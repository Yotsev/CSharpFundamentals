using System;

namespace _04.PrintAndSum
{
    class PrintAndSum
    {
        static void Main(string[] args)
        {
            int startOfRange = int.Parse(Console.ReadLine());
            int endOfRange = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startOfRange; i <= endOfRange; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine($"{Environment.NewLine}Sum: {sum}");
        }
    }
}
