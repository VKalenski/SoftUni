using System;

namespace _07._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PriceForHoliday = double.Parse(Console.ReadLine());
            int NumberOfPuzzles = int.Parse(Console.ReadLine());
            int NumberOfDolls = int.Parse(Console.ReadLine());
            int NumberOfBears = int.Parse(Console.ReadLine());
            int NumberOfMinions = int.Parse(Console.ReadLine());
            int NumberOfTrucks = int.Parse(Console.ReadLine());

            double Puzzle = NumberOfPuzzles * 2.60;
            double Doll = NumberOfDolls * 3.0;
            double Bear = NumberOfBears * 4.10;
            double Minion = NumberOfMinions * 8.20;
            double Truck = NumberOfTrucks * 2.0;
            double SumToysPrice = Puzzle + Doll + Bear + Minion + Truck;   // 680
            double SumToys = NumberOfPuzzles + NumberOfDolls + NumberOfBears + NumberOfMinions + NumberOfTrucks;
            double naem = SumToysPrice - (SumToysPrice * 0.10);

            if (SumToys >= 50)
            {
                double ToysDiscount = SumToysPrice - (SumToysPrice * 0.25);
                naem = ToysDiscount - (ToysDiscount * 0.10);
            }

            if (naem >= PriceForHoliday)
            {
                Console.WriteLine($"Yes! {naem - PriceForHoliday:F2} lv left.");
            }

            else if (naem < PriceForHoliday)
            {
                Console.WriteLine($"Not enough money! {PriceForHoliday - naem:F2} lv needed.");
            }
        }
    }
}
