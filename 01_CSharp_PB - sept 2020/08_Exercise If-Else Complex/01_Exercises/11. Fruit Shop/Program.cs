using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" ||
                dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" ||
                dayOfTheWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    double price = quantity * 2.50;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "apple")
                {
                    double price = quantity * 1.20;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "orange")
                {
                    double price = quantity * 0.85;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "grapefruit")
                {
                    double price = quantity * 1.45;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "kiwi")
                {
                    double price = quantity * 2.70;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "pineapple")
                {
                    double price = quantity * 5.50;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "grapes")
                {
                    double price = quantity * 3.85;
                    Console.WriteLine($"{price:F2}");
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    double price = quantity * 2.70;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "apple")
                {
                    double price = quantity * 1.25;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "orange")
                {
                    double price = quantity * 0.90;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "grapefruit")
                {
                    double price = quantity * 1.60;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "kiwi")
                {
                    double price = quantity * 3.00;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "pineapple")
                {
                    double price = quantity * 5.60;
                    Console.WriteLine($"{price:F2}");
                }

                else if (fruit == "grapes")
                {
                    double price = quantity * 4.20;
                    Console.WriteLine($"{price:F2}");
                }
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
