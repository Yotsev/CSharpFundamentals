using System;

namespace _10.TopNumber
{
    class TopNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                TopNum(i);
            }
        }

        static void TopNum(int num)
        {
            int number = num;
            int sum = 0;

            bool isOdd = false;

            while (number > 0)
            {
                int lastdigit = number % 10;
                sum += lastdigit;
                if (lastdigit % 2 == 1)
                {
                    isOdd = true;
                }
                number /= 10;
            }
            if (isOdd && sum % 8 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}
