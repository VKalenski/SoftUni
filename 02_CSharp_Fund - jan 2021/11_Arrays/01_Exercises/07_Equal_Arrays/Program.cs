using System;
using System.Linq;

namespace _07_Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLineNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondLineNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < firstLineNums.Length; i++)
            {
                if (firstLineNums[i] != secondLineNums[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            int sum = firstLineNums.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}