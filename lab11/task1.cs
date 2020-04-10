using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle tr1 = new Triangle(2, 4, 6);
                Triangle tr2 = new Triangle(7, 8, 12);

                Console.Write("Ввеiть число:  ");
                double num = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Площа(S)= {tr1.Area()}");
                Console.WriteLine($"Периметр(P)= {tr1.Perimeter()}");
                if (tr1 == tr2)
                    Console.WriteLine("Рiвний");
                else
                    Console.WriteLine("Не рiвний");

                Console.WriteLine($"Додавання {num}: {tr1 + num}");
                Console.WriteLine($"Вiднiмання {num}: {tr1 - num}");
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
