using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsCollection = Console.ReadLine()
                .ToLower()
                .Split(' ');

            Dictionary<string, int> wordsDict = new Dictionary<string, int>();
            foreach (string word in wordsCollection)
            {
                if (!wordsDict.ContainsKey(word))
                {
                    wordsDict[word] = 0;
                }
                wordsDict[word]++;
            }

            List<string> wordsList = wordsDict
                .Where(w => w.Value % 2 != 0)
                .Select(w => w.Key)
                .ToList();

            Console.WriteLine(string.Join(" ", wordsList));
        }
    }
}