using System;

namespace _06.BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int coutOpenBraket = 0;
            int coutColseBraket = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                string text = Console.ReadLine();

                if (text == "(")
                {
                    coutOpenBraket++;
                }
                else if (text == ")")
                {
                    coutColseBraket++;
                    if (coutOpenBraket - coutColseBraket != 0)
                    {
                        break;
                    }
                }
            }

            if (coutOpenBraket == coutColseBraket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
