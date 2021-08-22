using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class OrderByAge
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();
            
            while (command != "End")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = commandArgs[0];
                string id= commandArgs[1];
                int age = int.Parse(commandArgs[2]);

                Student student = new Student
                {
                    Name = name,
                    ID = id,
                    Age = age
                };

                students.Add(student);

                command = Console.ReadLine();
            }

            List<Student> sortedStudent = students.OrderBy(s => s.Age)
                .ToList();

            foreach (var student in sortedStudent)
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
