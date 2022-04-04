using System;

namespace _05._Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double RentForHall = double.Parse(Console.ReadLine());

            double CakePrice = RentForHall * 0.20;
            double Drinks = CakePrice - (CakePrice * 0.45);
            double Animator = RentForHall / 3;

            double sum = RentForHall + CakePrice + Drinks + Animator;
            Console.WriteLine(sum);
        }
    }
}
