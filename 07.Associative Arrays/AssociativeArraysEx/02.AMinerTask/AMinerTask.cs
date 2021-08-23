using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int lineCounter = 1;

            Dictionary<string, int> resources = new Dictionary<string, int>();

            string resource = string.Empty;
            
            while (input != "stop")
            {
                if (lineCounter % 2 == 1)
                {
                    resource = input;

                    if (!resources.ContainsKey(resource))
                    {
                        resources.Add(resource, 0);
                    }
                }
                else
                {
                    int quantitie = int.Parse(input);
                    resources[resource] += quantitie;
                }

                input = Console.ReadLine();
                lineCounter++;
            }

            foreach (KeyValuePair<string, int> item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
