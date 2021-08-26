using System;

namespace _01.BonusScoringSystem
{
    class BonusScoringSystem
    {
        static void Main(string[] args)
        {
            int studentCout = int.Parse(Console.ReadLine());
            int lectureCount = int.Parse(Console.ReadLine());
            double bonus = int.Parse(Console.ReadLine());

            
            double maxBonus = 0;
            int maxattendance = 0;


            for (int i = 1; i <= studentCout; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                double totalBonus = (attendance / (double)lectureCount) * (5 + bonus);

                if (totalBonus>maxBonus)
                {
                    maxBonus = totalBonus;
                    maxattendance = attendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxattendance} lectures.");
        }
    }
}
