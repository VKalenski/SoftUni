using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int NewProjects = int.Parse(Console.ReadLine());
            int HourForProject = 3;

            int HoursForAllProjects = (NewProjects * HourForProject);

            Console.WriteLine($"The architect {Name} will need " +
                $"{HoursForAllProjects} hours to complete {NewProjects} project/s.");
        }
    }
}
