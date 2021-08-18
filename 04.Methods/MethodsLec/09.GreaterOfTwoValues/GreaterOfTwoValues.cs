using System;

namespace _09.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type== "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int result = GetMax(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char seconChar = char.Parse(Console.ReadLine());

                char result = GetMax(firstChar, seconChar);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                string result = GetMax(firstString, secondString);
                Console.WriteLine(result);
            }
        }
        static int GetMax(int firstNum, int SecondNum)
        {
            int result = Math.Max(firstNum, SecondNum);
            return result;
        }
        static char GetMax(char firstChar, char secondChar)
        {
            int result = Math.Max(firstChar, secondChar);
            return (char)result;
        }
        static string GetMax(string firstString, string secondString)
        {
            int result = string.Compare(firstString, secondString);

            if (result<0)
            {
                return secondString;
            }
            else
            {
                return firstString;
            }
        }

    }
}
