using System;

namespace _01.DataTypeFinder
{
    class DataTypeFinder
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string type = string.Empty;
            
            while (command != "END")
            {
                bool isInt = int.TryParse(command, out int integer);
                bool isDouble = double.TryParse(command, out double floatingPoint);
                bool isChar = char.TryParse(command, out char character);
                bool isBool = bool.TryParse(command, out bool boolean);

                if (isInt)
                {
                    type = "integer";
                    Console.WriteLine($"{command} is {type} type");
                }
                else if (isDouble)
                {
                    type = "floating point";
                    Console.WriteLine($"{command} is {type} type");
                }
                else if (isChar)
                {
                    type = "character";
                    Console.WriteLine($"{command} is {type} type");
                }
                else if (isBool)
                {
                    type = "boolean";
                    Console.WriteLine($"{command} is {type} type");
                }
                else
                {
                    type = "string";
                    Console.WriteLine($"{command} is {type} type");
                }

                command = Console.ReadLine();
            }
        }
    }
}
