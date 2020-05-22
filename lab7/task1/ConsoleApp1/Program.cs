using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення матриці
            Console.Write("Розмiр матрицi = ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("Елемент [{0}][{1}] = ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //  вихід
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + " ");

                Console.WriteLine();
            }

            //  пошук
            int element = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i < j && matrix[i, j] > 0)
                        element *= matrix[i, j];
                }
            }

            Console.WriteLine((element > 1) ? $"Добуток позитивних елементiв = {element}" : "Немає позитивних елементів вище основної діагоналі.");
        }
    }
}
