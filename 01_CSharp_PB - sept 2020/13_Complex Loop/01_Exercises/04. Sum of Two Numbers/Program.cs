using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationCount = 0;
            bool magicNumberFound = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationCount++;
                    int sum = i + j;

                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCount} ({i} + {j} = {magicNumber})");
                        magicNumberFound = true;
                        break;
                    }
                }

                if (magicNumberFound)
                {
                    break;
                }
            }

            if (!magicNumberFound)
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}
