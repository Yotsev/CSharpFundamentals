using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class StudentAcademy
    {
        static void Main(string[] args)
        {
            int numberOfPairs = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfPairs; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students[studentName].Add(studentGrade);
                }
            }

            Dictionary<string, double> filteredStudents = new Dictionary<string, double>();

            foreach (KeyValuePair<string, List<double>> student in students)
            {

                double sum = 0.0;

                foreach (double grade in student.Value)
                {
                    sum += grade;
                }
                
                double avgGrade = sum / student.Value.Count;
                
                if (avgGrade >= 4.5)
                {
                    filteredStudents.Add(student.Key,avgGrade);
                }
            }

            List<KeyValuePair<string, double>> orderdStudents = filteredStudents.OrderByDescending(g => g.Value).ToList();

            foreach (var student in orderdStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
