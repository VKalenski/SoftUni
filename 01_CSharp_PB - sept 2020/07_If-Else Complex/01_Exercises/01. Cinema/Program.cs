using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (projection == "Premiere")
            {
                income = rows * column * 12.00;
            }

            else if (projection == "Normal")
            {
                income = rows * column * 7.50;
            }

            else if (projection == "Discount")
            {
                income = rows * column * 5.00;
            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}
