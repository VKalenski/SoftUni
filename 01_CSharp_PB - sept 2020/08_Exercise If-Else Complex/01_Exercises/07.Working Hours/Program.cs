using System;

namespace _07._Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            if (hour >= 10 && hour < 18 && (dayOfTheWeek == "Monday" ||
                dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" ||
                dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday" ||
                dayOfTheWeek == "Saturday"))
            {
                Console.WriteLine("open");
            }

            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
