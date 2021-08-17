using System;

namespace Pascal_Triangle
{
    //https://softuni.bg/forum/25593/technology-fundamentals-with-csharp-02-pascal-triangle-arrays-more-exercise
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[] currentArray = { 1 };
            
            for (int i = 1; i < rows; i++)
            {
                int[] nextArray = new int[currentArray.Length + 1];
               
                for (int j = 0; j < currentArray.Length; j++)
                {
                    nextArray[j] += currentArray[j];
                    nextArray[j + 1] += currentArray[j];
                }
                
                Console.WriteLine(string.Join(" ", currentArray));
                currentArray = nextArray;
            }
            
            Console.WriteLine(string.Join(" ", currentArray));
        }
    }
}