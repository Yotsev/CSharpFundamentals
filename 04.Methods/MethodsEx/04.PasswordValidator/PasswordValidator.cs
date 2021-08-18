using System;
using System.Linq;

namespace _04.PasswordValidator
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string passWord = Console.ReadLine();

            FullValidation(passWord);
        }

        static void FullValidation(string text)
        {
            bool isvalid = true;

            if (text.Length < 6 || text.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isvalid = false;
            }

            bool areAllLetterOrDigits = text.All(char.IsLetterOrDigit);
           if (!areAllLetterOrDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isvalid = false;
            }

            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    count++;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isvalid = false;
            }

            if (isvalid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}


