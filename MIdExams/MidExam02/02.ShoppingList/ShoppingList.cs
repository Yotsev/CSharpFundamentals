using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ShoppingList
{
    class ShoppingList
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string item = commandArgs[1];
                if (action == "Urgent")
                {
                    if (!products.Contains(item))
                    {
                        products.Insert(0, item);
                    }
                }
                else if (action == "Unnecessary")
                {
                    if (products.Contains(item))
                    {
                        products.Remove(item);
                    }
                }
                else if (action == "Correct")
                {
                    string newItem = commandArgs[2];

                    if (products.Contains(item))
                    {
                        int index = products.IndexOf(item);
                        products[index] = newItem;
                    }
                }
                else if (action == "Rearrange")
                {
                    if (products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", products));
        }
    }
}
