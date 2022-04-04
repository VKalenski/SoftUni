using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judgesCount = int.Parse(Console.ReadLine());
            double totalScoresSum = 0;
            int scoreCount = 0;

            while (true)
            {
                string presentation = Console.ReadLine();

                if (presentation == "Finish")
                {
                    break;
                }

                double currentScore = 0;

                for (int i = 0; i < judgesCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    currentScore += grade;
                    scoreCount++;
                    totalScoresSum += grade;
                }

                Console.WriteLine($"{presentation} - {currentScore / judgesCount:F2}.");
            }

            Console.WriteLine($"Student's final assessment is {totalScoresSum / scoreCount:F2}.");
        }
    }
}
