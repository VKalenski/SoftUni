using System;

namespace _09._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volumeSpace = width * length * height;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{volumeSpace} Cubic meters left.");
                    break;
                }

                int boxes = int.Parse(input);
                volumeSpace -= boxes;

                if (volumeSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volumeSpace)} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
