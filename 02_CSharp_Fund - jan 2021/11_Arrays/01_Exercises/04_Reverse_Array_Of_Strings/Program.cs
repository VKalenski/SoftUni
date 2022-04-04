using System;
using System.Linq;

namespace _04_Reverse_Array_Of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            Console.WriteLine(string.Join(" ", inputs.Reverse()));
        }
    }
}