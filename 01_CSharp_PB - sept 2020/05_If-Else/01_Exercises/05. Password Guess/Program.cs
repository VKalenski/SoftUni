using System;

namespace _05._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Word = Console.ReadLine();

            if (Word == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }

            else if (Word != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
