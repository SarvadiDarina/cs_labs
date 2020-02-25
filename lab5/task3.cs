using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Е(точність) = ");
            double accuracy = Convert.ToDouble(Console.ReadLine());
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double sum = 1;
            int n = 1;
            int k = 1;
            while (true)
            {
                double next_addition = Math.Abs(Math.Pow((x * Math.Log(a)), n) / k);
                if (next_addition >= accuracy)
                {
                    sum += next_addition;
                    n++;
                    k *= n;
                }
                else
                    break;
            }
            Console.WriteLine(" Сума - " + sum);
        }

    }
}