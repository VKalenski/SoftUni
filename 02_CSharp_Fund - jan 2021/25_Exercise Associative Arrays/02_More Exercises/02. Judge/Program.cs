using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Judge
{    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> stats = new Dictionary<string, Dictionary<string, int>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] input = command.Split(" -> ");

                string username = input[0];
                string contest = input[1];
                int points = int.Parse(input[2]);

                if (!stats.ContainsKey(contest))
                {
                    stats[contest] = new Dictionary<string, int>();
                }

                if (!stats[contest].ContainsKey(username))
                {
                    stats[contest][username] = 0;
                }

                if (stats[contest][username] < points)
                {
                    stats[contest][username] = points;
                }
            }

            foreach (var contest in stats)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int counter = 0;

                foreach (var participant in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{++counter}. {participant.Key} <::> {participant.Value}");
                }
            }

            Dictionary<string, int> totalPoints = new Dictionary<string, int>();

            foreach (var contest in stats)
            {
                foreach (var participant in contest.Value)
                {
                    if (!totalPoints.ContainsKey(participant.Key))
                    {
                        totalPoints[participant.Key] = 0;
                    }

                    totalPoints[participant.Key] += participant.Value;
                }
            }

            Console.WriteLine("Individual standings:");

            int count = 0;

            foreach (var item in totalPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{++count}. {item.Key} -> {item.Value}");
            }

        }
    }
}