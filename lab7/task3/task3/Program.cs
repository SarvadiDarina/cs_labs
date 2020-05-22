using System;

namespace task3
{
    class Program
    {

        //створюю матрицю
        static int[,] MatrixCreation(int row, int column)
            {
                int[,] matrix = new int[row, column];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write("Елемент [{0}][{1}] = ", i, j);
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return matrix;
            }

        // виводить матрицю
        static void MatrixOutput(int[,] matrix, int rows, int columns)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                        Console.Write(matrix[i, j] + " ");
                    Console.WriteLine();
                }
            }
               static void Main(string[] args)
            {
                // matrix A
                Console.Write("Рядки = ");
                int rA = Convert.ToInt32((Console.ReadLine()));
                Console.Write("Стовпцi =  ");
                int columnsA = Convert.ToInt32(Console.ReadLine());
                int[,] A = (MatrixCreation(rA, columnsA));

                MatrixOutput(A, rA, columnsA);

                // matrix B
                Console.Write("Рядки = ");
                int rB = Convert.ToInt32((Console.ReadLine()));
                Console.Write("Стовпцi = ");
                int columnsB = Convert.ToInt32(Console.ReadLine());
                int[,] B = MatrixCreation(rB, columnsB);

                MatrixOutput(B, rB, columnsB);

                if (columnsA != rA)
                    Console.Write("Кількість стовпців у першій матриці повинна дорівнювати кількості рядків у другій.");
                else
                {
                    //  matrix C
                    int[,] C = new int[columnsA, rB];
                    for (int i = 0; i < C.GetLength(0); i++)
                    {
                        for (int j = 0; j < C.GetLength(1); j++)
                        {
                            C[i, j] = 0;
                            for (int k = 0; k < A.GetLength(1); k++)
                                C[i, j] = C[i, j] + A[i, k] * B[k, j];
                        }
                    }

                    MatrixOutput(C, columnsA, rB);

                }
            }
        }
}
