using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForVacation = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int totalDays = 0;
            int spendingMoneyDays = 0;

            while (true)
            {
                string input = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());

                if (input == "save")
                {
                    ownedMoney += currentMoney;
                    spendingMoneyDays = 0;
                    totalDays++;
                }

                else if (input == "spend")
                {
                    if (ownedMoney - currentMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                    else
                    {
                        ownedMoney -= currentMoney;
                    }
                    spendingMoneyDays++;
                    totalDays++;
                }

                if (spendingMoneyDays == 5)
                {
                    break;
                }
                if (ownedMoney >= moneyNeededForVacation)
                {
                    break;
                }

            }

            if (spendingMoneyDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{totalDays}");
            }
            else if (ownedMoney >= moneyNeededForVacation)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }
    }
}
