using System;

namespace _03.ExtractFile
{
    class ExtractFile
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] splittedInput = input
                .Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string fileNameAndExtension = splittedInput[splittedInput.Length - 1];

            string[] elements = fileNameAndExtension
                .Split(".", StringSplitOptions.RemoveEmptyEntries);

            string fileExtension = elements[elements.Length - 1];
            string fileName = fileNameAndExtension.Replace($".{fileExtension}", string.Empty);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
