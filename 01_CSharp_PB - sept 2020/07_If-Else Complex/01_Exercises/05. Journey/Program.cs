using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double sum = 0;

            if (budget <= 100)
            {
                Console.WriteLine($"Somewhere in Bulgaria");

                if (season == "summer")
                {
                    sum = budget * 0.30;
                    Console.WriteLine($"Camp - {sum:F2}");
                }

                else if (season == "winter")
                {
                    sum = budget * 0.70;
                    Console.WriteLine($"Hotel - {sum:F2}");
                }
            }

            else if (budget <= 1000)
            {
                Console.WriteLine($"Somewhere in Balkans");

                if (season == "summer")
                {
                    sum = budget * 0.40;
                    Console.WriteLine($"Camp - {sum:F2}");
                }

                else if (season == "winter")
                {
                    sum = budget * 0.80;
                    Console.WriteLine($"Hotel - {sum:F2}");
                }
            }

            else if (budget > 1000)
            {
                Console.WriteLine($"Somewhere in Europe");
                sum = budget * 0.90;
                Console.WriteLine($"Hotel - {sum:F2}");
            }
        }
    }
}
