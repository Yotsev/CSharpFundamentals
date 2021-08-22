using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    class CompanyRoster
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Department> departments = new List<Department>();

            for (int i = 0; i < number; i++)
            {
                string[] employeeInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = employeeInfo[0];
                decimal salary = decimal.Parse(employeeInfo[1]);
                string employeeDepartment = employeeInfo[2];

                Employee employee = new Employee
                {
                    Name = name,
                    Salary = salary,
                    Department = employeeDepartment
                };

                Department existingDepartment = GetDeparmentByName(departments, employee.Department);

                if (existingDepartment != null)
                {
                    existingDepartment.Employees.Add(employee);
                }
                else
                {
                    Department department = new Department();
                    department.Name = employee.Department;
                    department.Employees.Add(employee);
                    departments.Add(department);
                }
            }

            decimal maxAvgSalary = 0.0m;
            string departmentWithMaxAvgSalary = string.Empty;

            foreach (Department department in departments)
            {
                decimal maxSalary = 0.0m;
                int employeeCount = 0;

                foreach (Employee employee in department.Employees)
                {
                    maxSalary += employee.Salary;
                    employeeCount++;
                }

                decimal avgSalary = maxSalary / employeeCount;

                if (avgSalary> maxAvgSalary)
                {
                    maxAvgSalary = avgSalary;
                    departmentWithMaxAvgSalary = department.Name;
                }

                if (employeeCount == 0)
                {
                    avgSalary = 0;
                }
            }

            List<Employee> employees = new List<Employee>();

            foreach (Department department1 in departments)
            {
                foreach (Employee employee in department1.Employees)
                {
                    if (employee.Department == departmentWithMaxAvgSalary)
                    {
                        employees.Add(employee);
                    }
                }
            }

            List<Employee> sortedEmployees = employees.OrderByDescending(e => e.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {departmentWithMaxAvgSalary}");
            foreach (Employee employee1 in sortedEmployees)
            {
                Console.WriteLine($"{employee1.Name} {employee1.Salary:f2}");
            }
        }

        static Department GetDeparmentByName(List<Department> departments, string department)
        {
            foreach (Department department1 in departments)
            {
                if (department1.Name == department)
                {
                    return department1;
                }
            }

            return null;
        }
    }

    class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}
