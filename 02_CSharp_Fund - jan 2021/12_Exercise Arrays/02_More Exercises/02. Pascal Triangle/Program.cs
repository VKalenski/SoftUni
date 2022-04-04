using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimention = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            int[] previous = new[] { 1 };

            for (int i = 2; i <= dimention; i++)
            {
                int[] values = new int[i];
                values[0] = 1;
                values[i - 1] = 1;

                for (int j = 1; j < i - 1; j++)
                {
                    values[j] = previous[j - 1] + previous[j];
                }

                Console.WriteLine(string.Join(" ", values));
                previous = values;
            }
        }
    }
}