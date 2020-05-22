using System;

namespace task6
{
    class Program
    {
        //створю матрицю
        static int[,] MatrixCreation(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("Елемент [{0}][{1}] = ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        // виводить матрицю
        static void MatrixOutput(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Розмiр матрицi = ");
            int size = Convert.ToInt32((Console.ReadLine()));
            int[,] matrix = MatrixCreation(size);

            MatrixOutput(matrix, size);

            int maxSum = -10;

            // прокручування елементів над головною діагоналлю
            for (int k = 0; k < size; k++)
            {
                int i = 0;
                int sum = 0;
                for (int j = k; j < size; j++)
                {
                    sum += matrix[i, j];
                    i++;
                }
                if (sum > maxSum)
                    maxSum = sum;
            }

            // через елементи нижче основної діагоналі
            for (int k = 1; k < size; k++)
            {
                int j = 0;
                int sum = 0;
                for (int i = k; i < size; i++)
                {
                    sum += matrix[i, j];
                    j++;
                }
                if (sum > maxSum)
                    maxSum = sum;
            }
            Console.WriteLine(maxSum);
        }
    }
}
