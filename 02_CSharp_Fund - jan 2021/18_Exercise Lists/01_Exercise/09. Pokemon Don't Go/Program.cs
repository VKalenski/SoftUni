using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sumRemovedElements = 0;

            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                int lastElementInput = input[input.Count - 1];

                int removedElementValue = 0;

                if (index < 0)
                {
                    removedElementValue = input[0];
                    sumRemovedElements += removedElementValue;
                    input[0] = input[input.Count - 1];
                    IncreaseDecrease(input, removedElementValue);
                }

                else if (index >= input.Count)
                {
                    removedElementValue = input[input.Count - 1];
                    sumRemovedElements += removedElementValue;
                    input[input.Count - 1] = input[0];
                    IncreaseDecrease(input, removedElementValue);
                }

                else
                {
                    removedElementValue = input[index];
                    sumRemovedElements += removedElementValue;
                    input.RemoveAt(index);
                    IncreaseDecrease(input, removedElementValue);
                }
            }

            Console.WriteLine($"{sumRemovedElements}");
        }

        private static void IncreaseDecrease(List<int> input, int removedElementValue)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= removedElementValue)
                {
                    input[i] += removedElementValue;
                }
                else
                {
                    input[i] -= removedElementValue;
                }
            }
        }
    }
}