using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (var num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count.Add(num, 1);
                }
            }

            foreach (var num in count)
            {
                Console.WriteLine($"{num.Key } -> {num.Value}");
            }
        }
    }
}