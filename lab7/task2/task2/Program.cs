using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matrix creation
            Console.Write("Розмiр матрицi = ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("Елеметн [{0}][{1}] = ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Matrix вихід
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }

            // Matrix пошук

            int[] vectorRow = new int[size];
            int[] vectorColumn = new int[size];
            Console.Write("Номер рядка = ");
            int rowNumber = Convert.ToInt32(Console.ReadLine());
            if (rowNumber >= size || rowNumber < 0)
                Console.WriteLine("Номер стовпця повинен бути в дiапазонi  [0;{0}]", size);

            else
            {
                // вибір ряду
                for (int i = rowNumber; i <= rowNumber; i++)
                {
                    for (int j = 0; j < size; j++)
                        vectorRow[j] = matrix[i, j];
                }
            }


            Console.Write("Номер рядка = ");
            int columnNumber = Convert.ToInt32(Console.ReadLine());
            if (columnNumber >= size || columnNumber < 0)
                Console.WriteLine("Номер стовпця повинен бути в дiапазонi [0;{0}]", size);
            // вибір стовпця
            for (int i = 0; i < size; i++)
            {
                for (int j = columnNumber; j <= columnNumber; j++)
                    vectorColumn[i] = matrix[i, j];
            }


            // скалярний добуток
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                result += vectorRow[i] * vectorColumn[i];
            }
            Console.WriteLine(result);
        }
    }
}
