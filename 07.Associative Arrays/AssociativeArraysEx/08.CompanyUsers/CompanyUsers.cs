using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class CompanyUsers
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string[] commandArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = commandArgs[0];
                string employeeId = commandArgs[1];


                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeId);
                }
                else
                {
                    if (companies[companyName].Contains(employeeId))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        companies[companyName].Add(employeeId);
                    }
                }

                command = Console.ReadLine();
            }

            List<KeyValuePair<string, List<string>>> orderedCompanies = companies.OrderBy(a => a.Key).ToList();

            foreach (KeyValuePair<string, List<string>> company in orderedCompanies)
            {
                Console.WriteLine(company.Key);
                
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
