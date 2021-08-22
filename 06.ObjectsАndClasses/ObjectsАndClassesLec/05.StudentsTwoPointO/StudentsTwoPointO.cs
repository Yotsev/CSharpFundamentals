using System;
using System.Collections.Generic;

namespace _05.StudentsTwoPointO
{
    class StudentsTwoPointO
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string town = info[3];

                if (isStudentExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = town;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = town
                    };
                    students.Add(student);
                }

                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool isStudentExisting(List<Student> students, string fName, string lname)
        {
            foreach (var student in students)
            {
                if (student.FirstName == fName && student.LastName == lname)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string fName, string lName)
        {
            Student existingStudent = null;

            foreach (var student in students)
            {
                if (student.FirstName == fName && student.LastName == lName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }

    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
