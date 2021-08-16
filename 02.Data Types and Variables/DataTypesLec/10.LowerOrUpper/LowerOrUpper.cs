using System;

namespace _10.LowerOrUpper
{
    class LowerOrUpper
    {
        static void Main(string[] args)
        {
            char charecter = char.Parse(Console.ReadLine());

            if ((int)charecter >= 65 && (int)charecter<=90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
