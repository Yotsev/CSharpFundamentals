using System;
using System.Linq;
using System.Text;

namespace _11.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int splintPoint = int.Parse(command[1]);

                    Exchange(splintPoint, initialArray);
                }
                else if (command[0] == "max" && command[1] == "even")
                {
                    MaxEven(initialArray);
                }
                else if (command[0] == "min" && command[1] == "even")
                {
                    MinEven(initialArray);
                }
                else if (command[0] == "max" && command[1] == "odd")
                {
                    MaxOdd(initialArray);
                }
                else if (command[0] == "min" && command[1] == "odd")
                {
                    MinOdd(initialArray);
                }
                else if (command[0] == "first" && command[2] == "even")
                {
                    int count = int.Parse(command[1]);

                    FirstNEven(count, initialArray);
                }
                else if (command[0] == "first" && command[2] == "odd")
                {
                    int count = int.Parse(command[1]);

                    FirstNOdd(count, initialArray);
                }
                else if (command[0] == "last" && command[2] == "even")
                {
                    int count = int.Parse(command[1]);

                    LastNEven(count, initialArray);
                }
                else if (command[0] == "last" && command[2] == "odd")
                {
                    int count = int.Parse(command[1]);

                    LastNOdd(count, initialArray);
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"[{string.Join(", ",initialArray)}]");
        }

        static void Exchange(int index, int[] array)
        {
            if (index < 0 || index > array.Length-1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                for (int i = 0; i <= index % array.Length; i++)
                {
                    int firstdigit = array[0];

                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        array[j] = array[1 + j];
                    }
                    array[array.Length - 1] = firstdigit;
                }
            }
        }

        static void MaxEven(int[] array)
        {
            int index = -1;
            int maxNumber = int.MinValue;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (maxNumber < array[i])
                    {
                        maxNumber = array[i];
                        index = i;
                    }
                    if (maxNumber == array[i])
                    {
                        if (index < i)
                        {
                            index = i;
                        }
                    }
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void MinEven(int[] array)
        {
            int index = -1;
            int minNumber = int.MaxValue;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (minNumber > array[i])
                    {
                        minNumber = array[i];
                        index = i;
                    }
                    if (minNumber == array[i])
                    {
                        if (index < i)
                        {
                            index = i;
                        }
                    }
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void MaxOdd(int[] array)
        {
            int index = -1;
            int maxNumber = int.MinValue;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    if (maxNumber < array[i])
                    {
                        maxNumber = array[i];
                        index = i;
                    }
                    if (maxNumber == array[i])
                    {
                        if (index < i)
                        {
                            index = i;
                        }
                    }
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void MinOdd(int[] array)
        {
            int index = -1;
            int minNumber = int.MaxValue;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    if (minNumber > array[i])
                    {
                        minNumber = array[i];
                        index = i;
                    }
                    if (minNumber == array[i])
                    {
                        if (index < i)
                        {
                            index = i;
                        }
                    }
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void FirstNEven(int num, int[] array)
        {
            StringBuilder numbers = new StringBuilder();

            if (num > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        numbers.Append(array[i]).Append(",");
                    }
                }
                string[] numbersAsstring = numbers.ToString().Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Console.WriteLine($"[{string.Join(", ", numbersAsstring.Take(num))}]");
            }
        }
        static void FirstNOdd(int num, int[] array)
        {
            StringBuilder numbers = new StringBuilder();

            if (num > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        numbers.Append(array[i]).Append(",");
                    }
                }
                string[] numbersAsstring = numbers.ToString().Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Console.WriteLine($"[{string.Join(", ", numbersAsstring.Take(num))}]");
            }
        }

        static void LastNEven(int num, int[] array)
        {
            StringBuilder numbers = new StringBuilder();

            if (num > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        numbers.Append(array[i]).Append(",");
                    }
                }
                string[] numbersAsstring = numbers.ToString().Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Console.WriteLine($"[{string.Join(", ", numbersAsstring.TakeLast(num))}]");
            }
        }
        static void LastNOdd(int num, int[] array)
        {
            StringBuilder numbers = new StringBuilder();

            if (num > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        numbers.Append(array[i]).Append(",");
                    }
                }
                string[] numbersAsstring = numbers.ToString().Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Console.WriteLine($"[{string.Join(", ", numbersAsstring.TakeLast(num))}]");
            }
        }
    }
}