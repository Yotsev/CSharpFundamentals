using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string commad = Console.ReadLine();

            while (commad != "course start")
            {
                string[] actions = commad.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (actions[0] == "Add")
                {
                    if (!courses.Contains(actions[1]))
                    {
                        courses.Add(actions[1]);
                    }
                }
                else if (actions[0] == "Insert")
                {
                    int index = int.Parse(actions[2]);

                    if (!courses.Contains(actions[1]))
                    {
                        courses.Insert(index, actions[1]);
                    }
                }
                else if (actions[0] == "Remove")
                {
                    if (courses.Contains(actions[1]))
                    {
                        courses.Remove(actions[1]);
                    }
                    if (courses.Contains($"{actions[1]}-Exercise")) ;
                    {
                        courses.Remove($"{actions[1]}-Exercise");
                    }
                }
                else if (actions[0] == "Swap")
                {
                    if (courses.Contains(actions[1]) && courses.Contains(actions[2]))
                    {
                        string tempCourse = actions[1];
                        string tempExercise = string.Empty;

                        int indexOfFirstCourse = courses.IndexOf(actions[1]);
                        courses.RemoveAt(indexOfFirstCourse);

                        if (indexOfFirstCourse < courses.Count)
                        {
                            if (courses[indexOfFirstCourse] == $"{actions[1]}-Exercise")
                            {
                                tempExercise = $"{actions[1]}-Exercise";
                                courses.RemoveAt(indexOfFirstCourse);
                            }
                        }

                        courses.Insert(indexOfFirstCourse, actions[2]);
                        int indexOfSecondCourse = courses.LastIndexOf(actions[2]);
                        courses.RemoveAt(indexOfSecondCourse);

                        if (indexOfSecondCourse <= courses.Count - 1)
                        {
                            if (courses[indexOfSecondCourse] == $"{actions[2]}-Exercise")
                            {
                                courses.Insert(indexOfFirstCourse + 1, $"{actions[2]}-Exercise");
                                courses.RemoveAt(indexOfSecondCourse + 1);
                            }
                        }
                        if (indexOfSecondCourse + 1 > courses.Count)
                        {
                            courses.Add(tempCourse);
                        }
                        else
                        {
                            courses.Insert(indexOfSecondCourse + 1, tempCourse);
                        }

                        if (tempExercise != string.Empty)
                        {
                            courses.Insert(indexOfSecondCourse + 2, tempExercise);
                        }
                    }
                }
                else if (actions[0] == "Exercise")
                {
                    if (courses.Contains(actions[1]))
                    {
                        int indexOfCourse = courses.IndexOf(actions[1]);

                        if (!courses.Contains($"{actions[1]}-{actions[0]}"))
                        {
                            courses.Insert(indexOfCourse + 1, $"{actions[1]}-{actions[0]}");
                        }
                    }
                    else
                    {
                        courses.Add(actions[1]);
                        courses.Add($"{actions[1]}-{actions[0]}");
                    }
                }

                Console.WriteLine(string.Join(" ",courses));
                commad = Console.ReadLine();
            }

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
    }
}
