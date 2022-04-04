using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;

            int sumOfSteps = 0;

            while (true)
            {
                string steps = Console.ReadLine();
                int stepsCount = 0;

                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    stepsCount = int.Parse(steps);
                    sumOfSteps += stepsCount;
                    break;
                }

                stepsCount = int.Parse(steps);
                sumOfSteps += stepsCount;

                if (sumOfSteps >= goal)
                {
                    break;
                }
            }

            if (sumOfSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sumOfSteps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal - sumOfSteps} more steps to reach goal.");
            }
        }
    }
}
