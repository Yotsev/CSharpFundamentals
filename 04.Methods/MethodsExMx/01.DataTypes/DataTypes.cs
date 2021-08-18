using System;

namespace _01.DataTypes
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            
            if (inputType == "int")
            {
                int number = int.Parse(Console.ReadLine());
                int result = Type(number);
                Console.WriteLine(result);
            }
            else if (inputType == "real")
            {
                double number = double.Parse(Console.ReadLine());
                double result = Type(number);
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                string text = Console.ReadLine();
                string result = Type(text);
                Console.WriteLine(result);
            }
        }
        
        static int Type(int num=0)
        {
            int result = num * 2;
            return result;
        }
        static double Type (double num=0.0)
        {
            double result = num * 1.5;
            return result;
        }
        static string Type(string input)
        {
            string finalTest = $"${input}$";
            return finalTest;
        }

    }
}
