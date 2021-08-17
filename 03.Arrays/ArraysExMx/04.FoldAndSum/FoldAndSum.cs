using System;
using System.Linq;

namespace _04.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] firstRow = new int[initialArray.Length / 2];
            int[] secondRow = new int[initialArray.Length / 2];
           
            //middle half
            for (int i = initialArray.Length /4; i < (initialArray.Length/4)*3; i++)
            {
                secondRow[i-initialArray.Length/4] = initialArray[i];
            }
            
            //first half of folded
            for (int i = 0; i < initialArray.Length/4; i++)
            {
                firstRow[i] = initialArray[i];
            }
            
            //second half of folded
            for (int i = initialArray.Length/4*3; i < initialArray.Length; i++)
            {
                firstRow[i-initialArray.Length/4*2] = initialArray[i];
            }
            
            //reversing first half
            Array.Reverse(firstRow, 0, firstRow.Length / 2);
            //reversing second half
            Array.Reverse(firstRow, firstRow.Length / 2, firstRow.Length / 2);

            //summing the elements
            int[] sumFirstAndSecondArrays = new int[initialArray.Length / 2];
            for (int i = 0; i < sumFirstAndSecondArrays.Length; i++)
            {
                sumFirstAndSecondArrays[i] = firstRow[i] + secondRow[i];
            }
            
            //printing
            Console.WriteLine(string.Join(" ",sumFirstAndSecondArrays));
        }
    }
}
