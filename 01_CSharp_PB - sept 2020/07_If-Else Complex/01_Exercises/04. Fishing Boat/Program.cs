using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());

            double rent = 0;

            if (season == "Spring")
            {
                rent = 3000;

                if (peopleCount <= 6)
                {
                    rent -= rent * 0.10;
                }

                else if (peopleCount >= 7 && peopleCount <= 11)
                {
                    rent -= rent * 0.15;
                }

                else if (peopleCount > 12)
                {
                    rent -= rent * 0.25;
                }
            }

            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;

                if (peopleCount <= 6)
                {
                    rent -= rent * 0.10;
                }

                else if (peopleCount >= 7 && peopleCount <= 11)
                {
                    rent -= rent * 0.15;
                }

                else if (peopleCount > 12)
                {
                    rent -= rent * 0.25;
                }
            }

            else if (season == "Winter")
            {
                rent = 2600;

                if (peopleCount <= 6)
                {
                    rent -= rent * 0.10;
                }

                else if (peopleCount >= 7 && peopleCount <= 11)
                {
                    rent -= rent * 0.15;
                }

                else if (peopleCount > 12)
                {
                    rent -= rent * 0.25;
                }
            }

            if (peopleCount % 2 == 0 && season != "Autumn")
            {
                rent -= rent * 0.05;
            }

            if (rent <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - rent:F2} leva left.");
            }

            else if (rent > budget)
            {
                Console.WriteLine($"Not enough money! You need {rent - budget:F2} leva.");
            }
        }
    }
}
