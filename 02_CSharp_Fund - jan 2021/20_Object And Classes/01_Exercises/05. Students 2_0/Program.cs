using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Students> students = new List<Students>();

            while (input != "end")
            {
                string[] token = input.Split();
                string firstName = token[0];
                string lastname = token[1];
                int age = int.Parse(token[2]);
                string city = token[3];

                Students student = students
                    .FirstOrDefault(s => s.FirstName == firstName && s.Lastname == lastname);
                if (student != null)
                {
                    student.FirstName = firstName;
                    student.Lastname = lastname;
                    student.Age = age;
                    student.City = city;
                }
                else
                {
                    student = new Students();
                    student.FirstName = firstName;
                    student.Lastname = lastname;
                    student.Age = age;
                    student.City = city;
                    students.Add(student);

                }

                input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            List<Students> filterStudents = students.Where(c => c.City == filterCity).ToList();
            foreach (Students student in filterStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.Lastname} is {student.Age} years old.");
            }
        }

        class Students
        {
            public string FirstName { get; set; }

            public string Lastname { get; set; }

            public int Age { get; set; }

            public string City { get; set; }
        }
    }
}