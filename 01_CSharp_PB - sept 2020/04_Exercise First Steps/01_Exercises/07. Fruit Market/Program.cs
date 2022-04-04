using System;

namespace _07._Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double StrawberriesPrice = double.Parse(Console.ReadLine());
            double bananasCapacity = double.Parse(Console.ReadLine());
            double OrangeCapacity = double.Parse(Console.ReadLine());
            double RaspberriesCapacity = double.Parse(Console.ReadLine());
            double StrawberriesCapacity = double.Parse(Console.ReadLine());

            double RaspberriesPrice = StrawberriesPrice / 2;
            double OrangePrice = RaspberriesPrice - (RaspberriesPrice * 0.40);
            double BananasPrice = RaspberriesPrice - (RaspberriesPrice * 0.80);

            double TotalSumForRasberies = RaspberriesPrice * RaspberriesCapacity;
            double TotalSumForOranges = OrangePrice * OrangeCapacity;
            double TotalSumForBananas = BananasPrice * bananasCapacity;
            double TotalSumForStrawberies = StrawberriesPrice * StrawberriesCapacity;

            double TotalSum = TotalSumForRasberies + TotalSumForOranges +
                                TotalSumForBananas + TotalSumForStrawberies;
            Console.WriteLine($"{TotalSum:F2}");
        }
    }
}
