using System;
using System.Linq;

namespace _03_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 0)
                {
                    number[i] = 0;
                }

                Console.WriteLine($"{number[i]} => {(int)Math.Round(number[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}