using System;
using System.Linq;

namespace _10.LadyBugs
{
    class LadyBugs
    {

        // The Fucking bane of my existence - DONE!
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexOfLadybugs = Console.ReadLine()
                .Split(" ", StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[] field = new int[fieldSize];

            for (int i = 0; i < indexOfLadybugs.Length; i++)
            {
                if (indexOfLadybugs[i] >= 0 && indexOfLadybugs[i] < field.Length)
                {
                    field[indexOfLadybugs[i]] = 1;
                }
            }
            while (command[0] != "end")
            {
                int positon = int.Parse(command[0]);
                string side = command[1];
                int flyLenght = int.Parse(command[2]);

                if (flyLenght < 0 && command[1] == "left")
                {
                    command[1] = "right";
                    flyLenght = Math.Abs(flyLenght);
                }
                else if (flyLenght < 0 && command[1] == "right")
                {
                    command[1] = "left";
                    flyLenght = Math.Abs(flyLenght);
                }

                if (command[1] == "right")
                {
                    if (positon >= 0 && positon < field.Length)
                    {
                        if (field[positon] == 1)
                        {
                            field[positon] = 0;

                            if (positon + flyLenght >= 0 && positon + flyLenght < field.Length)
                            {
                                for (int i = positon + flyLenght; i < field.Length; i += flyLenght)
                                {
                                    if (field[i] == 1)
                                    {
                                        continue;
                                    }
                                    else if (field[i] == 0)
                                    {
                                        field[i] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (command[1] == "left")
                {
                    if (positon >= 0 && positon < field.Length)
                    {
                        if (field[positon] == 1)
                        {
                            field[positon] = 0;

                            if (positon - flyLenght >= 0 && positon - flyLenght < field.Length)
                            {
                                for (int i = positon - flyLenght; i >= 0; i -= flyLenght)
                                {
                                    if (field[i] == 1)
                                    {
                                        continue;
                                    }
                                    else if (field[i] == 0)
                                    {
                                        field[i] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
