using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            bool isLogeIn = false;
            bool isBlocked = false;
            int attempysCounter = 0;


            while (!isLogeIn && !isBlocked)
            {
                string inputPassword = Console.ReadLine();

                if (inputPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    isLogeIn = true;
                }

                else
                {
                    attempysCounter += 1;
                    if (attempysCounter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        isBlocked = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}