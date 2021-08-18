using System;

namespace _06.CalculateRectangleArea
{
    class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = RectangleArea(width, height);

            Console.WriteLine(area);
        }

       static double RectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

    }
}
