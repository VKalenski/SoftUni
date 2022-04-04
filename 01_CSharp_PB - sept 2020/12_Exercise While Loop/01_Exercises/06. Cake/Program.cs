using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());

            int totalCakeSlices = width * high;
            int finalCakeSlices = width * high;
            int totalTakenSlices = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }

                int takenSlices = int.Parse(input);

                totalCakeSlices -= takenSlices;
                totalTakenSlices += takenSlices;

                if (totalCakeSlices <= 0)
                {
                    finalCakeSlices = width * high;
                    Console.WriteLine($"No more cake left! You need {totalTakenSlices - finalCakeSlices} pieces more.");
                    break;
                }
            }

            if (totalCakeSlices > 0)
            {
                Console.WriteLine($"{finalCakeSlices - totalTakenSlices} pieces are left.");
            }
        }
    }
}
