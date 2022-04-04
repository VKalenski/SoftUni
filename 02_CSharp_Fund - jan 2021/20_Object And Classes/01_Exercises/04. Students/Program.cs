using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] token = input.Split();
                string firstName = token[0];
                string lastName = token[1];
                int age = int.Parse(token[2]);
                string town = token[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Town = town;
                student.Town = town;

                students.Add(student);

                input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();
            List<Student> filterStudents = students.Where(n => n.Town == filterCity).ToList();

            foreach (Student student in filterStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age  } years old.");
            }
        }
        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string Town { get; set; }
        }
    }
}