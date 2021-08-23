using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Courses
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] commandArgs = command
               .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = commandArgs[0];
                string studentName = commandArgs[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }

                command = Console.ReadLine();
            }

            List<KeyValuePair<string, List<string>>> sortedCourses = courses.OrderByDescending(c => c.Value.Count).ToList();

            foreach (var item in sortedCourses)
            {
                item.Value.OrderBy(s => s);
            }


            foreach (KeyValuePair<string, List<string>> course in sortedCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                
                foreach (string student in course.Value.OrderBy(s => s))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
