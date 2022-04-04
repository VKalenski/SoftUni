using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            const int breakHour = 3;

            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int allEmployee = employeeOne + employeeTwo + employeeThree;

            int neededTimeWithoutBreak = (int)Math.Ceiling(students * 1.0 / allEmployee);

            int breakTime = neededTimeWithoutBreak / breakHour;

            if (neededTimeWithoutBreak % breakHour == 0 && breakTime > 0)
            {
                breakTime--;
            }

            Console.WriteLine($"Time needed: {neededTimeWithoutBreak + breakTime}h.");
        }
    }
}