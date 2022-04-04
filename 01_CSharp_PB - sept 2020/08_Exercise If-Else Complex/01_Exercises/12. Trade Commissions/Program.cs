using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volumeOfTheSales = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (volumeOfTheSales >= 0 && volumeOfTheSales <= 500)
                {
                    double commision = volumeOfTheSales * 0.05;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales > 500 && volumeOfTheSales <= 1000)
                {
                    double commision = volumeOfTheSales * 0.07;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales > 1000 && volumeOfTheSales <= 10000)
                {
                    double commision = volumeOfTheSales * 0.08;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales > 10000)
                {
                    double commision = volumeOfTheSales * 0.12;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales < 0)
                {
                    Console.WriteLine("error");
                }
            }

            else if (city == "Varna")
            {
                if (volumeOfTheSales >= 0 && volumeOfTheSales <= 500)
                {
                    double commision = volumeOfTheSales * 0.045;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales > 500 && volumeOfTheSales <= 1000)
                {
                    double commision = volumeOfTheSales * 0.075;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales > 1000 && volumeOfTheSales <= 10000)
                {
                    double commision = volumeOfTheSales * 0.10;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales > 10000)
                {
                    double commision = volumeOfTheSales * 0.13;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales < 0)
                {
                    Console.WriteLine("error");
                }
            }

            else if (city == "Plovdiv")
            {
                if (volumeOfTheSales >= 0 && volumeOfTheSales <= 500)
                {
                    double commision = volumeOfTheSales * 0.055;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales > 500 && volumeOfTheSales <= 1000)
                {
                    double commision = volumeOfTheSales * 0.08;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales > 1000 && volumeOfTheSales <= 10000)
                {
                    double commision = volumeOfTheSales * 0.12;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales > 10000)
                {
                    double commision = volumeOfTheSales * 0.145;
                    Console.WriteLine($"{commision:F2}");
                }

                else if (volumeOfTheSales < 0)
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
