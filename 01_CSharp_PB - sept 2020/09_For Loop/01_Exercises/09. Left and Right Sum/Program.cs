using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftNumbers = 0;
            int rightNumbers = 0;
            int sumAll = 0;

            for (int i = 0; i < n; i++)
            {
                sumAll = int.Parse(Console.ReadLine());
                leftNumbers += sumAll;
            }
            for (int i = 0; i < n; i++)
            {
                sumAll = int.Parse(Console.ReadLine());
                rightNumbers += sumAll;
            }
            if (leftNumbers == rightNumbers)
            {
                Console.WriteLine($"Yes, sum = {leftNumbers}");
            }

            else if (leftNumbers > rightNumbers)
            {
                Console.WriteLine($"No, diff = {leftNumbers - rightNumbers}");
            }

            else if (leftNumbers < rightNumbers)
            {
                Console.WriteLine($"No, diff = {rightNumbers - leftNumbers}");
            }
        }
    }
}
