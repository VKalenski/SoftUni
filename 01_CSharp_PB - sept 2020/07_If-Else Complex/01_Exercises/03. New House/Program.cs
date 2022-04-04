using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            if (flower == "Roses")
            {
                if (numberFlowers < 80)
                {
                    double priceForFlowers = numberFlowers * 5;

                    if (budget > priceForFlowers)
                    {
                        double difference = budget - priceForFlowers;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceForFlowers)
                    {
                        double difference = priceForFlowers - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }

                else if (numberFlowers >= 80)
                {
                    double priceForFlowers = numberFlowers * 5;
                    double priceWithDiscount = priceForFlowers * 0.90;

                    if (budget > priceWithDiscount)
                    {
                        double difference = budget - priceWithDiscount;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceForFlowers)
                    {
                        double difference = priceWithDiscount - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }
            }

            else if (flower == "Dahlias")
            {
                if (numberFlowers < 90)
                {
                    double priceForFlowers = numberFlowers * 3.80;

                    if (budget > priceForFlowers)
                    {
                        double difference = budget - priceForFlowers;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceForFlowers)
                    {
                        double difference = priceForFlowers - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }

                else if (numberFlowers >= 90)
                {
                    double priceForFlowers = numberFlowers * 3.80;
                    double priceWithDiscount = priceForFlowers * 0.85;

                    if (budget > priceWithDiscount)
                    {
                        double difference = budget - priceWithDiscount;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceWithDiscount)
                    {
                        double difference = priceWithDiscount - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }
            }

            else if (flower == "Tulips")
            {
                if (numberFlowers < 80)
                {
                    double priceForFlowers = numberFlowers * 2.80;

                    if (budget > priceForFlowers)
                    {
                        double difference = budget - priceForFlowers;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceForFlowers)
                    {
                        double difference = priceForFlowers - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }

                else if (numberFlowers >= 80)
                {
                    double priceForFlowers = numberFlowers * 2.80;
                    double priceWithDiscount = priceForFlowers * 0.85;

                    if (budget > priceWithDiscount)
                    {
                        double difference = budget - priceWithDiscount;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceWithDiscount)
                    {
                        double difference = priceWithDiscount - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }
            }

            else if (flower == "Narcissus")
            {
                if (numberFlowers < 120)
                {
                    double priceForFlowers = numberFlowers * 3.00;
                    double priceWithDiscount = priceForFlowers * 1.15;

                    if (budget > priceWithDiscount)
                    {
                        double difference = budget - priceWithDiscount;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceWithDiscount)
                    {
                        double difference = priceWithDiscount - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }

                else if (numberFlowers >= 120)
                {
                    double priceForFlowers = numberFlowers * 3.00;

                    if (budget > priceForFlowers)
                    {
                        double difference = budget - priceForFlowers;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceForFlowers)
                    {
                        double difference = priceForFlowers - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }
            }

            else if (flower == "Gladiolus")
            {
                if (numberFlowers < 80)
                {
                    double priceForFlowers = numberFlowers * 2.50;
                    double priceWithDiscount = priceForFlowers * 1.20;

                    if (budget > priceWithDiscount)
                    {
                        double difference = budget - priceWithDiscount;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceWithDiscount)
                    {
                        double difference = priceWithDiscount - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }

                else if (numberFlowers >= 80)
                {
                    double priceForFlowers = numberFlowers * 2.50;

                    if (budget > priceForFlowers)
                    {
                        double difference = budget - priceForFlowers;
                        Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {difference:F2} leva left.");
                    }

                    else if (budget < priceForFlowers)
                    {
                        double difference = priceForFlowers - budget;
                        Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                    }
                }
            }
        }
    }
}
