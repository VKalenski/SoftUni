using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeNumbersSum = 0;
            int nonPrimeNumbersSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                int currentNum = int.Parse(input);

                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                int count = 0;

                for (int i = 1; i <= currentNum; i++)
                {
                    if (currentNum % i == 0)
                    {
                        count++;
                    }
                }

                if (count > 2)
                {
                    nonPrimeNumbersSum += currentNum;
                }
                else
                {
                    primeNumbersSum += currentNum;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");
        }
    }
}
