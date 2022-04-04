using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {Lastname}: {Grade:f2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] studentData = Console.ReadLine()
                    .Split();
                Student student = new Student
                {
                    FirstName = studentData[0],
                    Lastname = studentData[1],
                    Grade = double.Parse(studentData[2])
                };
                students.Add(student);
            }

            List<Student> sortedStudents = students
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (var sortedStudent in sortedStudents)
            {
                Console.WriteLine(sortedStudent);
            }
        }
    }
}