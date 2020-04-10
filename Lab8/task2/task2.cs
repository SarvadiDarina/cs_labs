using System;
using System.Threading.Channels;

namespace task2
{
    class Program
    {
        static int[] SumOfVectors(int[] vector1, int[] vector2)
        {

            int[] resVector = new int[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
                resVector[i] = vector1[i] + vector2[i];
            return resVector;
        }

        static int[] DifferenceOfVectors(int[] vector1, int[] vector2)
        {

            int[] resVector = new int[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
                resVector[i] = vector1[i] - vector2[i];
            return resVector;
        }

        static int[] VectorMultiplyByNumber(int[] vector, int number)
        {
            for (int i = 0; i < vector.Length; i++)
                vector[i] *= number;
            return vector;
        }


        static void Main(string[] args)
        {
            Console.Write("Розмір вектора: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int[] b = new int[size];
            int[] c = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Координат [{0}] вектора 1: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int j = 0; j < size; j++)
            {
                Console.Write("Координат [{0}] вектора 2: ", j);
                b[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int j = 0; j < size; j++)
            {
                Console.Write("Координат [{0}] вектора 3: ", j);
                c[j] = Convert.ToInt32(Console.ReadLine());
            }

            int[] b3 = VectorMultiplyByNumber(b, 3);
            int[] c2 = VectorMultiplyByNumber(c, 2);
            int[] res = SumOfVectors(DifferenceOfVectors(a, b3), c2);

            for (int i = 0; i < size; i++)
                Console.Write(" " + res[i]);

        }
    }
}