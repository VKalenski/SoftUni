using System;
using System.Linq;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = 0;
            int trashedMouse = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadsets += 1;
                }

                if (i % 3 == 0)
                {
                    trashedMouse += 1;
                }

                if (i % 6 == 0)
                {
                    trashedKeyboard += 1;
                }

                if (i % 12 == 0)
                {
                    trashedDisplay += 1;
                }
            }

            double rageExpenses = trashedDisplay * displayPrice +
                trashedMouse * mousePrice +
                trashedHeadsets * headsetPrice +
                trashedKeyboard * keyboardPrice;

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}