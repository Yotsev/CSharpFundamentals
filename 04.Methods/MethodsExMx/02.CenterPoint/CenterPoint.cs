using System;

namespace _02.CenterPodouble
{
    class CenterPodouble
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            ClosestPoint(x1, y1, x2, y2);
        }

        static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double DistanceFromCenterFirstPoint = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double DistanceFromCenterSecondPoint = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (DistanceFromCenterFirstPoint < DistanceFromCenterSecondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
