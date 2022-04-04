using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ',', ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            SortedDictionary<string, List<decimal>> dict = new SortedDictionary<string, List<decimal>>();

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];

                dict.Add(current, new List<decimal>());
                string patternHealth = @"[^0123456789\+\-\*\/\.]";
                MatchCollection health = Regex.Matches(current, patternHealth);
                decimal countHealth = 0;

                foreach (Match item in health)
                {
                    countHealth += char.Parse(item.Value.ToString());
                }

                string patternDamage = @"-?\d+[.]?\d*";

                MatchCollection damage = Regex.Matches(current, patternDamage);
                decimal countDamage = 0;

                foreach (Match item in damage)
                {

                    countDamage += decimal.Parse(item.Value);
                }

                for (int j = 0; j < current.Length; j++)
                {
                    if (current[j] == '*')
                    {
                        countDamage *= 2;
                    }
                    else if (current[j] == '/')
                    {
                        countDamage /= 2;
                    }
                }

                dict[current].Add(countHealth);
                dict[current].Add(countDamage);
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");

            }
        }
    }
}