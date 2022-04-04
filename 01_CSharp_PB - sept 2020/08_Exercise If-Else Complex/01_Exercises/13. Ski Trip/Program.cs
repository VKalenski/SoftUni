using System;

namespace _13._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dayOfStay = double.Parse(Console.ReadLine());
            string kindRoom = Console.ReadLine();
            string ratingForStay = Console.ReadLine();

            if (kindRoom == "room for one person")
            {
                if (dayOfStay < 10 && ratingForStay == "positive")
                {
                    double firstPrice = (dayOfStay - 1) * 18;
                    double priceWithPositiveRating = firstPrice + (firstPrice * 0.25);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay >= 10 && dayOfStay <= 15 && ratingForStay == "positive")
                {
                    double firstPrice = (dayOfStay - 1) * 18;
                    double priceWithPositiveRating = firstPrice + (firstPrice * 0.25);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay > 15 && ratingForStay == "positive")
                {
                    double firstPrice = (dayOfStay - 1) * 18;
                    double priceWithPositiveRating = firstPrice + (firstPrice * 0.25);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay > 15 && ratingForStay == "negative")
                {
                    double firstPrice = (dayOfStay - 1) * 18;
                    double priceWithPositiveRating = firstPrice - (firstPrice * 0.10);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay >= 10 && dayOfStay <= 15 && ratingForStay == "negative")
                {
                    double firstPrice = (dayOfStay - 1) * 18;
                    double priceWithPositiveRating = firstPrice - (firstPrice * 0.10);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay > 15 && ratingForStay == "negative")
                {
                    double firstPrice = (dayOfStay - 1) * 18;
                    double priceWithPositiveRating = firstPrice - (firstPrice * 0.10);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }
            }

            if (kindRoom == "apartment")
            {
                if (dayOfStay < 10 && ratingForStay == "positive")
                {
                    double firstPrice = (dayOfStay - 1) * 25;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.30);
                    double priceWithPositiveRating = priceWithDiscount + (priceWithDiscount * 0.25);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay >= 10 && dayOfStay <= 15 && ratingForStay == "positive")
                {
                    double firstPrice = (dayOfStay - 1) * 25;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.35);
                    double priceWithPositiveRating = priceWithDiscount + (priceWithDiscount * 0.25);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay > 15 && ratingForStay == "positive")
                {
                    double firstPrice = (dayOfStay - 1) * 25;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.50);
                    double priceWithPositiveRating = priceWithDiscount + (priceWithDiscount * 0.25);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay < 10 && ratingForStay == "negative")
                {
                    double firstPrice = (dayOfStay - 1) * 25;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.30);
                    double priceWithNegativeRating = priceWithDiscount - (priceWithDiscount * 0.10);
                    Console.WriteLine($"{priceWithNegativeRating:F2}");
                }

                else if (dayOfStay >= 10 && dayOfStay <= 15 && ratingForStay == "negative")
                {
                    double firstPrice = (dayOfStay - 1) * 25;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.35);
                    double priceWithNegativeRating = priceWithDiscount - (priceWithDiscount * 0.10);
                    Console.WriteLine($"{priceWithNegativeRating:F2}");
                }

                else if (dayOfStay > 15 && ratingForStay == "negative")
                {
                    double firstPrice = (dayOfStay - 1) * 25;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.50);
                    double priceWithNegativeRating = priceWithDiscount - (priceWithDiscount * 0.10);
                    Console.WriteLine($"{priceWithNegativeRating:F2}");
                }
            }

            if (kindRoom == "president apartment")
            {
                if (dayOfStay < 10 && ratingForStay == "positive")
                {
                    double firstPrice = (dayOfStay - 1) * 35;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.10);
                    double priceWithPositiveRating = priceWithDiscount + (priceWithDiscount * 0.25);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay >= 10 && dayOfStay <= 15 && ratingForStay == "positive")
                {
                    double firstPrice = (dayOfStay - 1) * 35;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.15);
                    double priceWithPositiveRating = priceWithDiscount + (priceWithDiscount * 0.25);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay > 15 && ratingForStay == "positive")
                {
                    double firstPrice = (dayOfStay - 1) * 35;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.20);
                    double priceWithPositiveRating = priceWithDiscount + (priceWithDiscount * 0.25);
                    Console.WriteLine($"{priceWithPositiveRating:F2}");
                }

                else if (dayOfStay < 10 && ratingForStay == "negative")
                {
                    double firstPrice = (dayOfStay - 1) * 35;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.10);
                    double priceWithNegativeRating = priceWithDiscount - (priceWithDiscount * 0.10);
                    Console.WriteLine($"{priceWithNegativeRating:F2}");
                }

                else if (dayOfStay >= 10 && dayOfStay <= 15 && ratingForStay == "negative")
                {
                    double firstPrice = (dayOfStay - 1) * 35;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.15);
                    double priceWithNegativeRating = priceWithDiscount - (priceWithDiscount * 0.10);
                    Console.WriteLine($"{priceWithNegativeRating:F2}");
                }

                else if (dayOfStay > 15 && ratingForStay == "negative")
                {
                    double firstPrice = (dayOfStay - 1) * 35;
                    double priceWithDiscount = firstPrice - (firstPrice * 0.20);
                    double priceWithNegativeRating = priceWithDiscount - (priceWithDiscount * 0.10);
                    Console.WriteLine($"{priceWithNegativeRating:F2}");
                }
            }
        }
    }
}
