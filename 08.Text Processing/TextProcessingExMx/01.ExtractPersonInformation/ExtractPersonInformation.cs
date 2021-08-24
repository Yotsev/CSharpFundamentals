using System;

namespace _01.ExtractPersonInformation
{
    class ExtractPersonInformation
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                int firstIndexOfName = input.IndexOf("@")+1;
                int lastIndexOfName = input.IndexOf("|");

                string name = input.Substring(firstIndexOfName, lastIndexOfName - firstIndexOfName);

                int firstIndexOfAge = input.IndexOf("#") + 1;
                int lastIndexOfAge = input.IndexOf("*");

                string age = input.Substring(firstIndexOfAge, lastIndexOfAge - firstIndexOfAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
