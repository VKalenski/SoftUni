using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposite = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double yearlyInterest = double.Parse(Console.ReadLine());

            double amount = deposite * yearlyInterest / 100;
            double mounthInterest = amount / 12;

            double sum = deposite + (month * mounthInterest);
            Console.WriteLine(sum);
        }
    }
}
