using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle tr1 = new Triangle(3, 4, 5);
                Triangle tr2 = new Triangle(6, 8, 10);

                Console.Write("Введіть число: ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Площа(S) = {tr1.Area()}");
                Console.WriteLine($"Периметр(P) = {tr1.Perimeter()}");
                if (tr1 == tr2)
                    Console.WriteLine("Рівний");
                else
                    Console.WriteLine("Не рівний");

                Console.WriteLine($"Додавання {num}: {tr1 + num}");
                Console.WriteLine($"Віднімання{num}: {tr1 - num}");
                Console.WriteLine($"Множення {num}: {tr1 * num}");


                Triangle copiedTriangle = new Triangle(tr2);
                Console.WriteLine(copiedTriangle);
            }

            catch
            {
                Console.WriteLine("Сторона має додатнє число");
            }
        }
    }
}
