using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Encrypt_Sort_And_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>
            {
                'a','A',
                'e','E',
                'i','I',
                'o','O',
                'u','U'
            };

            int linesNumbers = int.Parse(Console.ReadLine());
            int[] sumOfAll = new int[linesNumbers];
            for (int i = 0; i < linesNumbers; i++)
            {
                string word = Console.ReadLine();
                int sum = 0;

                for (int k = 0; k < word.Length; k++)
                {
                    if (vowels.Contains(word[k]))
                    {
                        sum = sum + (int)word[k] * word.Length;
                    }
                    else
                    {
                        sum = sum + (int)(word[k] / word.Length);
                    }
                }

                sumOfAll[i] = sum;
            }

            var listOfSum = sumOfAll.ToList();
            var newListWithoutZero = listOfSum.Where(x => x != 0);
            var newOrderList = newListWithoutZero.OrderBy(x => x);

            foreach (var item in newOrderList)
            {
                Console.WriteLine(item);
            }
        }
    }
}