using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    class OldestFamilyMember
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] peopleInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = peopleInfo[0];
                int age = int.Parse(peopleInfo[1]);

                Person person = new Person
                {
                    Name = name,
                    Age = age
                };

                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMemeber(family);

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }
        public List<Person> Persons { get; set; }

        public void AddMember(Person member)
        {
            Persons.Add(member);
        }

        public Person GetOldestMemeber(Family family)
        {
            Person oldestPerson = family.Persons.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestPerson;
        }
    }
}
