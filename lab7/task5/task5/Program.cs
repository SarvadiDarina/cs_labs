using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть рядкiв = ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кiлькiсть стовпцiв =  ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Елемент = ");
                    matrix[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i].Min() > 0)
                {
                    int product = 1;
                    foreach (int element in matrix[i])
                        product *= element;

                    Console.WriteLine($"Виріб елементів в { i + 1} рядок є {product}.");
                }
                else
                    Console.WriteLine($"{i + 1} row contains negative element.");
            }
        }
    }
}
