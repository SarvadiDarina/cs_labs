using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec1 = new int[3];
            int[] vec2 = new int[3];
            for (int x = 0; x < 3; x++)
            {
                Console.Write("[{0}] координати першого вектора ", x + 1);
                int v1 = Convert.ToInt32(Console.ReadLine());
                vec1[x] = v1;
            }
            for (int x = 0; x < 3; x++)
            {
                Console.Write("[{0}] координати другого вектора ", x + 1);
                int v2 = Convert.ToInt32(Console.ReadLine());
                vec2[x] = v2;
            }
            int xResult = vec1[1] * vec2[2] - vec1[2] * vec2[1];
            int yResult = vec1[2] * vec2[0] - vec1[0] * vec2[2];
            int zResult = vec1[0] * vec2[1] - vec1[1] * vec2[0];
            Console.WriteLine("Результат - ({0}, {1}, {2})", xResult, yResult, zResult);

        }
    }
}