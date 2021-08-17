using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    class EncryptSortAndPrintArray
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            int[] allSums = new int[numberOfStrings];
            int sum = 0;
            
            for (int i = 0; i < numberOfStrings; i++)
            {
                string input = Console.ReadLine();
                // A, E, I, O, U, Y
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'a' || input[j] == 'e' || input[j] == 'i' || input[j] == 'o' || input[j] == 'u' 
                        || input[j] == 'A' || input[j] == 'E' || input[j] == 'I' || input[j] == 'O' || input[j] == 'U')
                    {
                        sum += input[j] * input.Length;
                    }
                    else
                    {
                        sum += input[j] / input.Length;
                    }
                }
                allSums[i] = sum;
                sum = 0;
            }
            Array.Sort(allSums);
            
            foreach (var item in allSums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
