using System;
using System.Linq;

namespace _02.CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string commonElements = string.Empty;

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i].Equals(firstArray[j]))
                    {
                        commonElements += secondArray[i] + " ";
                    }
                }
            }
           // string[] result = secondArray.Intersect(firstArray).ToArray();
            Console.WriteLine(commonElements);
        }
    }
}
