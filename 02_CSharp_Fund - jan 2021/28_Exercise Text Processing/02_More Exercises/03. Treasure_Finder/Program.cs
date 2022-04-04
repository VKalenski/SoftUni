using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();

            while (text != "find")
            {
                StringBuilder decryptMsg = new StringBuilder();
                int keyIndex = 0;

                foreach (var item in text)
                {
                    if (keyIndex > keys.Length - 1)
                    {
                        keyIndex = 0;
                    }
                    char decryptChar = (char)(item - keys[keyIndex]);
                    keyIndex++;
                    decryptMsg.Append(decryptChar);
                }

                string msg = decryptMsg.ToString();

                string type = msg[(msg.IndexOf('&') + 1)..msg.LastIndexOf('&')];
                string coordinates = msg[(msg.IndexOf('<') + 1)..msg.LastIndexOf('>')];
                Console.WriteLine($"Found {type} at {coordinates}");
                text = Console.ReadLine();
            }
        }
    }
}