using System;
using System.IO;
using System.Linq;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = File.ReadAllLines("./text.txt");
            for (int i = 0; i < line.Length; i++)
            {
                string currLine = line[i];
                int letterCount = CountOfLetters(currLine);
                int punctionalCount = PunctionalCharCount(currLine);

                line[i] = $"Line {i + 1}: {currLine}. ({letterCount})({punctionalCount})";
            }

            File.WriteAllLines("../../../output.txt", line);
        }

        static int PunctionalCharCount(string currLine)
        {
            char[] punctionalMarks = { '-', ',', '.', '!', '?' };
            int count = 0;
            for (int i = 0; i < currLine.Length; i++)
            {
                char currChar = currLine[i];
                if (char.IsPunctuation(currChar))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountOfLetters(string currLine)
        {
            int count = 0;
            for (int i = 0; i < currLine.Length; i++)
            {
                char currChar = currLine[i];
                if (char.IsLetter(currChar))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
