using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Inventory
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string commnad = Console.ReadLine();

            while (commnad != "Craft!")
            {
                string[] commandArgs = commnad.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string item = commandArgs[1];

                if (action == "Collect")
                {
                    if (items.Contains(item))
                    {
                        commnad = Console.ReadLine();
                        continue;
                    }
                    items.Add(item);
                }
                else if (action == "Drop")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if (action == "Combine Items")
                {
                    string[] itemsToCombine = item.Split(":", StringSplitOptions.RemoveEmptyEntries);

                    if (items.Contains(itemsToCombine[0]))
                    {
                        int index = items.IndexOf(itemsToCombine[0]);

                        items.Insert(index+1, itemsToCombine[1]);
                    }
                }
                else if (action == "Renew")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                }
                commnad = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
