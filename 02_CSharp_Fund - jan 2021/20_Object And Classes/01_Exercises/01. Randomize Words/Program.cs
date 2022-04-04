using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rdm = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int pos = rdm.Next(words.Length);
                string word = words[i];
                words[i] = words[pos];
                words[pos] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}