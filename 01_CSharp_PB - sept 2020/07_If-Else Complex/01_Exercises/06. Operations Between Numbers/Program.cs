using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            if ((symbol == "/" || symbol == "%") && number2 == 0)
            {
                Console.WriteLine($"Cannot divide {number1} by zero");
            }

            else if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                int sum = 0;
                if (symbol == "+")
                {
                    sum = number1 + number2;

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {symbol} {number2} = {sum} - even");
                    }

                    else if (sum % 2 != 0)
                    {
                        Console.WriteLine($"{number1} {symbol} {number2} = {sum} - odd");
                    }
                }

                else if (symbol == "-")
                {
                    sum = number1 - number2;

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {symbol} {number2} = {sum} - even");
                    }

                    else if (sum % 2 != 0)
                    {
                        Console.WriteLine($"{number1} {symbol} {number2} = {sum} - odd");
                    }
                }

                else if (symbol == "*")
                {
                    sum = number1 * number2;

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {symbol} {number2} = {sum} - even");
                    }

                    else if (sum % 2 != 0)
                    {
                        Console.WriteLine($"{number1} {symbol} {number2} = {sum} - odd");
                    }
                }
            }

            else if (symbol == "/")
            {
                double sum = 1.00 * number1 / number2;
                Console.WriteLine($"{number1} / {number2} = {sum:F2}");
            }

            else if (symbol == "%")
            {
                Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
            }
        }
    }
}
