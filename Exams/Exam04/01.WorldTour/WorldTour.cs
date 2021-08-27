using System;
using System.Text;

namespace _01.WorldTour
{
    class WorldTour
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] commandArgs = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                bool isValidAction = false;

                if (action == "Add Stop")
                {
                    int index = int.Parse(commandArgs[1]);
                    string stop = commandArgs[2];

                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, stop);
                    }
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (
                        startIndex >= 0
                        && endIndex >= 0
                        && startIndex < stops.Length
                        && endIndex < stops.Length
                        )
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                else if (action == "Switch")
                {
                    string oldValue = commandArgs[1];
                    string newValue = commandArgs[2];

                    if (stops.Contains(oldValue))
                    {
                        stops = stops.Replace(oldValue, newValue);
                    }
                }

                Console.WriteLine(stops);
                
                command = Console.ReadLine();
            }
           
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}

