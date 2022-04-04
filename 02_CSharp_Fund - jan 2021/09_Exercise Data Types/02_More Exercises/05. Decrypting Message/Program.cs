using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            string output = "";

            while (count > 0)
            {
                output += ((char)(char.Parse(Console.ReadLine()) + key)).ToString();
                count--;
            }

            Console.WriteLine(output);
        }
    }
}