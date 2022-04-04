using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string inputData = Console.ReadLine();

            PrintDataType(inputType, inputData);
        }
        private static void PrintDataType(string type, string data)
        {
            if (type == "int")
            {
                int number = int.Parse(data) * 2;
                Console.WriteLine(number);
            }
            else if (type == "real")
            {
                double number = double.Parse(data) * 1.5;
                Console.WriteLine($"{number:f2}");
            }
            else if (type == "string")
            {
                Console.WriteLine("$" + data + "$");
            }
        }
    }
}