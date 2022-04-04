using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;

            if (!HasValidLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (ConstainsInvalidCharacters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!ConstainsDigitCount(password, 2))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ConstainsDigitCount(string password, int count)
        {
            int foundDigitsCount = 0;

            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    foundDigitsCount += 1;

                    if (foundDigitsCount == count)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool ConstainsInvalidCharacters(string password)
        {
            foreach (var symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool HasValidLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}