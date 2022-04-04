using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double firstFactorial = CalculateFactorial(first);
            double secondFactorial = CalculateFactorial(second);


            double result = firstFactorial / secondFactorial;

            Console.WriteLine($"{result:F2}");
        }

        private static double CalculateFactorial(int number)
        {
            double factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}