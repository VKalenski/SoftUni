using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Anonymous_Threat
{
    class Anonymous_Threat
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "3:1")
            {
                switch (command[0])
                {
                    case "merge":

                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);

                        if (startIndex < 0 || startIndex > data.Count - 1)
                        {
                            startIndex = 0;
                        }

                        if (endIndex > data.Count - 1 || endIndex < 0)
                        {
                            endIndex = data.Count - 1;
                        }

                        Merge(data, startIndex, endIndex);
                        break;
                    case "divide":

                        int index = int.Parse(command[1]);
                        int partitions = int.Parse(command[2]);

                        Divide(data, index, partitions);
                        break;
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(' ', data));
        }

        private static List<string> Merge(List<string> data, int startIndex, int endIndex)
        {
            StringBuilder concatenated = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                concatenated.Append(data[i]);
            }

            for (int i = endIndex; i >= startIndex; i--)
            {
                data.RemoveAt(i);
            }

            data.Insert(startIndex, concatenated.ToString());

            return data;
        }

        private static List<string> Divide(List<string> data, int index, int partitions)
        {
            StringBuilder subElements = new StringBuilder(data[index]);

            int partitionsLength = subElements.Length / partitions;

            List<string> subStrings = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                subStrings.Add(subElements.ToString().Substring(0, partitionsLength));
                subElements.Remove(0, partitionsLength);
            }

            data.RemoveAt(index);

            for (int i = subStrings.Count - 1; i >= 0; i--)
            {
                data.Insert(index, subStrings[i]);
            }

            if (subElements.ToString() != string.Empty)
            {
                data[partitions - 1] += subElements;
            }

            return data;
        }
    }
}