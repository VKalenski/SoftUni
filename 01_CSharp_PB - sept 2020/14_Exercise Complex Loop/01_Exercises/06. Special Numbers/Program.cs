using System;

namespace _06._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = true;

            for (int i = 1111; i < 9999; i++)
            {
                string currentNumber = i.ToString();
                isSpecial = true;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int digit = int.Parse(currentNumber[j].ToString());

                    if (digit == 0 || n % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
