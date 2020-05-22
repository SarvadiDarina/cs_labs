using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr1 = new Triangle(2, 4, 6);

            //зміна значень за індексом
            tr1['a'] = 4;
            tr1['b'] = 8;
            tr1['c'] = 12;
            Console.WriteLine("Площа = " + tr1.Area());
            Console.WriteLine("Периметр = " + tr1.Perimeter());
            Console.WriteLine(tr1);
        }
    }
}
