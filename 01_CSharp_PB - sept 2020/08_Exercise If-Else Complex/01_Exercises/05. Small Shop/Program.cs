using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    double price = quantity * 0.50;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "water")
                {
                    double price = quantity * 0.80;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "beer")
                {
                    double price = quantity * 1.20;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "sweets")
                {
                    double price = quantity * 1.45;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "peanuts")
                {
                    double price = quantity * 1.60;
                    Console.WriteLine($"{price:F2}");
                }
            }

            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    double price = quantity * 0.40;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "water")
                {
                    double price = quantity * 0.70;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "beer")
                {
                    double price = quantity * 1.15;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "sweets")
                {
                    double price = quantity * 1.30;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "peanuts")
                {
                    double price = quantity * 1.50;
                    Console.WriteLine($"{price:F2}");
                }
            }

            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    double price = quantity * 0.45;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "water")
                {
                    double price = quantity * 0.70;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "beer")
                {
                    double price = quantity * 1.10;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "sweets")
                {
                    double price = quantity * 1.35;
                    Console.WriteLine($"{price:F2}");
                }

                else if (product == "peanuts")
                {
                    double price = quantity * 1.55;
                    Console.WriteLine($"{price:F2}");
                }
            }
        }
    }
}
