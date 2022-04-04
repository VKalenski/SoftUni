using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }

                int budget = int.Parse(Console.ReadLine());

                int savedMoney = 0;

                while (savedMoney < budget)
                {
                    int money = int.Parse(Console.ReadLine());
                    savedMoney += money;
                }

                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
