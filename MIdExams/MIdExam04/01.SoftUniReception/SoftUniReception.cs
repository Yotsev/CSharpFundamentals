using System;

namespace _01.SoftUniReception
{
    class SoftUniReception
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int totalAnswers = firstEmployee + secondEmployee + thirdEmployee;

            int time = 0;
            while (students > 0)
            {
                time++;
                if (time % 4 == 0)
                {
                    continue;
                }
                students -= totalAnswers;
            }

            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
