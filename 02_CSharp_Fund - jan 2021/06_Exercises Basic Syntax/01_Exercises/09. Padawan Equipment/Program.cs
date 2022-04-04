using System;
using System.Linq;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int lightsaberCount = (int)Math.Ceiling(studentCount * 1.1);
            int beltsCount = studentCount - studentCount / 6;

            double totalPrice = lightsaberPrice * lightsaberCount +
                robePrice * studentCount +
                beltPrice * beltsCount;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - budget):F2}lv more.");
            }
        }
    }
}