using System;

namespace _09.PalindromeIntegers
{
    class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command!="END")
            {
                int number = int.Parse(command);

                bool result = Palindrome(number);
                Console.WriteLine(result.ToString().ToLower());

                command = Console.ReadLine();
            }
        }

        static bool Palindrome(int num)
        {
            string number = num.ToString();
            string backwordsNumber = string.Empty;

            while (num > 0)
            {
                int lastDigit = num % 10;
                backwordsNumber += lastDigit.ToString();
                num /= 10;
            }

            if (backwordsNumber == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
