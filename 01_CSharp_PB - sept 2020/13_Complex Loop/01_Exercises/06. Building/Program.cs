using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countFloors = int.Parse(Console.ReadLine());
            int countRooms = int.Parse(Console.ReadLine());

            for (int f = countFloors; f >= 1; f--)
            {
                for (int r = 0; r < countRooms; r++)
                {
                    if (f == countFloors)
                    {
                        Console.Write($"L{f}{r} ");
                    }
                    else
                    {
                        if (f % 2 == 0)
                        {
                            Console.Write($"O{f}{r} ");
                        }
                        else
                        {
                            Console.Write($"A{f}{r} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
