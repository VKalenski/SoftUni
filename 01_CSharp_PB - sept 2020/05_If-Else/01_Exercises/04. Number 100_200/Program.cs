using System;

namespace _04._Number_100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Answer = int.Parse(Console.ReadLine());
                        
            if (Answer < 100)
            {
                Console.WriteLine("Less than 100");
            }

            else if (Answer <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }

            else if (Answer > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
