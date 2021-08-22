using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Students
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Student student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                students.Add(student);
            }

            List<Student> orderedStudents = new List<Student>();

            orderedStudents = students.OrderByDescending(s => s.Grade).ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
