using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenNumbers = 0;
            int oddsNumbers = 0;

            for (int i = 1; i <= n; i++)
            {

                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenNumbers += number;
                }
                else if (i % 2 != 0)
                {
                    oddsNumbers += number;
                }
            }

            if (evenNumbers == oddsNumbers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenNumbers}");
            }
            else if (evenNumbers > oddsNumbers)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {evenNumbers - oddsNumbers}");
            }
            else if (oddsNumbers > evenNumbers)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {oddsNumbers - evenNumbers}");
            }
        }
    }
}
