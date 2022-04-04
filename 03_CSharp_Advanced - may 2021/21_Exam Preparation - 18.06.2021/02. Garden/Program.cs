using System;

namespace _02._Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int n = int.Parse(input[0].ToString());
            int m = int.Parse(input[1].ToString());

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            string commandInput;

            while ((commandInput = Console.ReadLine()) != "Bloom Bloom Plow") //Input can be wrong!
            {
                string[] command = commandInput.Split();

                int row = int.Parse(command[0].ToString());
                int col = int.Parse(command[1].ToString());

                if (row < n && col < m)
                {
                    for (int i = 0; i < n; i++)
                    {
                        matrix[i, col]++;
                    }

                    for (int i = 0; i < m; i++)
                    {
                        if (i != col)
                        {
                            matrix[row, i]++;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }

            PrintIntMatrix(matrix);
        }
        public static void PrintIntMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}