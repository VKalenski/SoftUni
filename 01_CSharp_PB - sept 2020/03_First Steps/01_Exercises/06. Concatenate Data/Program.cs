using System;

namespace _06._Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FirstName = Console.ReadLine();
            var LastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", FirstName, LastName, age, town);
        }
    }
}
