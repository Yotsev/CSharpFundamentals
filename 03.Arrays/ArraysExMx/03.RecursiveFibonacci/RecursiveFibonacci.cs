using System;

namespace _03.RecursiveFibonacci
{
    //https://softuni.bg/trainings/resources/video/8455/video-14-april-2016-atanas-rusenov-part-i-algorithms-april-2016/1331
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            arrayFibonacci = new long[n + 1];

            GetFibonacci(n);

            Console.WriteLine(arrayFibonacci[n]);
        }

        static long[] arrayFibonacci = null;
        static long GetFibonacci(long index)
        {
            if (arrayFibonacci[index] != 0)
            {
                return arrayFibonacci[index];
            }
            if (index <= 2)
            {
                arrayFibonacci[index] = 1;
                return arrayFibonacci[index];
            }
            arrayFibonacci[index] = GetFibonacci(index - 1) + GetFibonacci(index - 2);

            return arrayFibonacci[index];
        }
    }
}
