using System;

namespace _06._Charity_Campaign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CakePrice = 45;
            double Waffles = 5.80;
            double Pancakes = 3.20;

            double Days = int.Parse(Console.ReadLine());
            int Backers = int.Parse(Console.ReadLine());
            int CakeCount = int.Parse(Console.ReadLine());
            int WafflesCount = int.Parse(Console.ReadLine());
            int PancakesCount = int.Parse(Console.ReadLine());

            int TotalSumForCakesPerDay = CakePrice * CakeCount;
            double TotalSumForWafflesPerDay = Waffles * WafflesCount;
            double TotalSumForPancakesPerDay = Pancakes * PancakesCount;

            double TotalSumPerDay = (TotalSumForCakesPerDay + TotalSumForWafflesPerDay +
                TotalSumForPancakesPerDay) * Backers;
            double TotalSum = TotalSumPerDay * Days;

            double LeftSum = TotalSum - (TotalSum / 8);

            Console.WriteLine(LeftSum);
        }
    }
}
