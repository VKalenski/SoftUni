using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = Console.ReadLine()[0];
            char endLetter = Console.ReadLine()[0];
            string randomText = Console.ReadLine();
            int sum = 0;

            foreach (var item in randomText)
            {
                if (item > Math.Min(startLetter, endLetter) && item < Math.Max(startLetter, endLetter))
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}