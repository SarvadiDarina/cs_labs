using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TTriangle tr1 = new TTriangle(3, 4, 5);
                TTriangle tr2 = new TTriangle(6, 8, 10);  
                TTrianglePrizm a = new TTrianglePrizm(18, 3, 10, 4);
                TTrianglePrizm k = new TTrianglePrizm(11, 13, 1, 2);

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
                Console.WriteLine($"Tr1 = Tr2: { tr1 == tr2}");

                TTriangle copiedTriangle = new TTriangle(tr2);
                Console.WriteLine(copiedTriangle);
                Console.Write("Введіть число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Площа(S) = {a.Area()}");
                Console.WriteLine($"Обєм(V) = {a.Volume()}");
                if (tr1 == tr2)
                    Console.WriteLine("Рівний");
                else
                    Console.WriteLine("Не рівний");

                Console.WriteLine($"Додавання {num2}: {a + num2}");
                Console.WriteLine($"Віднімання{num2}: {a - num2}");
                Console.WriteLine($"Множення {num2}: {a * num2}");
                Console.WriteLine($"A = B: { a==k}");

                TTrianglePrizm copiedTTrianglePrizm = new TTrianglePrizm(k);
                Console.WriteLine(copiedTTrianglePrizm);
            }

            catch
            {
                Console.WriteLine("Сторона має додатнє число");
            }

            
           
           
        }
    }
    }

