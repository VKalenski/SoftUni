using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            Console.WriteLine(MultiplyEvenAndOddDigits(num));
        }
        static int MultiplyEvenAndOddDigits(int num)
        {
            return CalculateDigitsSum(num, 0) * (CalculateDigitsSum(num, 1));
        }
        static int CalculateDigitsSum(int num, int isOdd)
        {
            int sum = 0;
            string number = num.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                int curentDigits = int.Parse(number[i].ToString());
                if (curentDigits % 2 == isOdd)
                {
                    sum += curentDigits;
                }
            }

            return sum;
        }
    }
}