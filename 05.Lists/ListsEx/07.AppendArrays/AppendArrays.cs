using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class AppendArrays
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> initalLists = input.Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<List<string>> lists = new List<List<string>>();

            for (int i = 0; i < initalLists.Count; i++)
            {
                lists.Add(initalLists[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            List<string> finalList = new List<string>();

            for (int i = lists.Count-1; i >= 0; i--)
            {
                for (int j = 0; j < lists[i].Count; j++)
                {
                    finalList.Add(lists[i][j]);
                }
            }

            Console.WriteLine(string.Join(" ",finalList));
        }
    }
}
