using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string firstElemnt = input[0];

                for (int j = 1; j < input.Length; j++)
                {
                    int previousIdx = j - 1;
                    input[previousIdx] = input[j];
                }
                input[input.Length - 1] = firstElemnt;
            }

            foreach (var element in input)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}