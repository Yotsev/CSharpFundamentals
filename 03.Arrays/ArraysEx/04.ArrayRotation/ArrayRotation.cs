using System;

namespace _03.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string firstdigit = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[1 + j];
                }
                array[array.Length - 1] = firstdigit;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
