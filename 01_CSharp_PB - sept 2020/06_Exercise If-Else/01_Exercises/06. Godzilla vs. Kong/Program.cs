using System;

namespace _06._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double priceForCloth = double.Parse(Console.ReadLine());

            double sumForDecor = budget * 0.10;
            double sumForClothes = statist * priceForCloth;

            if (statist > 150)
            {
                sumForClothes -= sumForClothes * 0.10;
            }

            double totalSum = sumForDecor + sumForClothes;

            if (totalSum > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum - budget:F2} leva more.");
            }

            else if (totalSum <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalSum:F2} leva left.");
            }
        }
    }
}