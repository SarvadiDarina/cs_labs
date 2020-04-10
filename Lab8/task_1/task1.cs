using System;

namespace task1
{
    class Program
    {
        static double Sum(double x)
        {
            if (x > 3)
            {
                double k = 0;
                for (int i = 1; i < 7; i++)
                    k += Math.Sin(Math.Pow(x, i));
                return k;
            }
            else
            {
                double z = -1;
                double k = 0;
                double a = Math.Cos(x);
                for (int i = 1; i < 6; i++)
                {
                    k = k + z * a;
                    a = Math.Cos(a);
                    z = -z;
                }
                return k;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введіть a = ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть b = ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result1 = Sum(num1);
            double result2 = Sum(num2);
            Console.WriteLine(Math.Min(result1, result2));
        }
    }
