using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int Dogs = int.Parse(Console.ReadLine());
            int OtherAnimals = int.Parse(Console.ReadLine());

            double PriceForDogs = (Dogs * 2.5);
            double PriceForOtherAnimals = (OtherAnimals * 4);

            double Sum = PriceForDogs + PriceForOtherAnimals;
            Console.WriteLine(Sum + " " + "lv.");
        }
    }
}
