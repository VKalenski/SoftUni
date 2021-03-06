using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x != 0));

            Stack<int> freshness = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int dippingSauce = 150;
            int greenSalad = 250;
            int chocolateCake = 300;
            int lobster = 400;

            int sauceCount = 0;
            int saladCount = 0;
            int cakeCount = 0;
            int lobsterCount = 0;

            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                int sum = ingredients.Peek() * freshness.Peek();

                if (sum == dippingSauce || sum == greenSalad || sum == chocolateCake || sum == lobster)
                {
                    if (sum == dippingSauce)
                    {
                        sauceCount++;
                    }
                    else if (sum == greenSalad)
                    {
                        saladCount++;
                    }
                    else if (sum == chocolateCake)
                    {
                        cakeCount++;
                    }
                    else
                    {
                        lobsterCount++;
                    }

                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    freshness.Pop();
                    int newIngredient = ingredients.Dequeue() + 5;
                    ingredients.Enqueue(newIngredient);
                }
            }

            if (sauceCount >= 1 && saladCount >= 1 && cakeCount >= 1 && lobsterCount >= 1)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            if (cakeCount > 0)
            {
                Console.WriteLine($" # Chocolate cake --> {cakeCount}");
            }

            if (sauceCount > 0)
            {
                Console.WriteLine($" # Dipping sauce --> {sauceCount}");
            }

            if (saladCount > 0)
            {
                Console.WriteLine($" # Green salad --> {saladCount}");
            }

            if (lobsterCount > 0)
            {
                Console.WriteLine($" # Lobster --> {lobsterCount}");
            }
        }
    }
}