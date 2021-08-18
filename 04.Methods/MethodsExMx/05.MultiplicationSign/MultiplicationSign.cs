using System;

namespace _05.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            string result = Sign(firstNum, secondNum, thirdNum);

            Console.WriteLine(result);
        }

        static string Sign(int firstNum, int secondNum, int thirdNum)
        {
            int[] numbers = new int[3];
            numbers[0] = firstNum;
            numbers[1] = secondNum;
            numbers[2] = thirdNum;
            
            int counter = 0;
            bool isZero = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    counter++;
                }

                if (numbers[i] == 0)
                {
                    isZero = true;
                    break;
                }
            }

            if (isZero)
            {
                return "zero";
            }
            else if (counter == 1 || counter == 3)
            {
                return "negative";
            }
            else
            {
                return "positive";
            }
        }
    }
}
