using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int min = 10;
            while (num > 0)
            {
                if (num % 10 < min)
                    min = num % 10;

                num /= 10;
            }
            Console.WriteLine("Найменше число - {0}", min);
        }
    }
}