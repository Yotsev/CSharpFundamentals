using System;

namespace _03.LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstline = LineLenght(x1, y1, x2, y2);
            double seconLine = LineLenght(x3, y3, x4, y4);

            if (firstline >= seconLine)
            {
                bool isCloser = ClosestPoint(x1, y1, x2, y2);
                if (isCloser)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                bool isCloser = ClosestPoint(x3, y3, x4, y4);

                if (isCloser)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static double LineLenght(double x1, double y1, double x2, double y2)
        {
            double distence = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

            return distence;
        }

        static bool ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double DistanceFromCenterFirstPoint = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double DistanceFromCenterSecondPoint = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            bool isFirst = false;
            if (DistanceFromCenterFirstPoint <= DistanceFromCenterSecondPoint)
            {
                isFirst = true;
            }

            return isFirst;
        }
    }
}
