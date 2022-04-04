using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            double totalPriceForStudio = 0;
            double totalPriceForApartment = 0;


            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                totalPriceForStudio = studioPrice * nights;
                totalPriceForApartment = apartmentPrice * nights;

                if (nights > 7 && nights <= 14)
                {
                    totalPriceForStudio -= totalPriceForStudio * 0.05;
                }

                else if (nights > 14)
                {
                    totalPriceForStudio -= totalPriceForStudio * 0.30;
                    totalPriceForApartment -= totalPriceForApartment * 0.10;
                }
            }

            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                totalPriceForStudio = studioPrice * nights;
                totalPriceForApartment = apartmentPrice * nights;

                if (nights > 14)
                {
                    totalPriceForStudio -= totalPriceForStudio * 0.20;
                    totalPriceForApartment -= totalPriceForApartment * 0.10;
                }
            }

            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;

                totalPriceForStudio = studioPrice * nights;
                totalPriceForApartment = apartmentPrice * nights;

                if (nights > 14)
                {
                    totalPriceForApartment -= totalPriceForApartment * 0.10;
                }
            }

            Console.WriteLine($"Apartment: {totalPriceForApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceForStudio:F2} lv.");
        }
    }
}
