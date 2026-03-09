using System;

namespace MatrizOO
{
    public class SquareMatrix
    {
        private int[,] matrix;
        private int n;

        public SquareMatrix(int n)
        {
            this.n = n;
            matrix = new int[n, n];
        }

        public void FillMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (i + 1) - j;
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        public int SumMatrix()
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        public int MaxValue()
        {
            int max = matrix[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
            }

            return max;
        }

        public int MinValue()
        {
            int min = matrix[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
            }

            return min;
        }
    }
}