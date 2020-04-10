using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class TTrianglePrizm: Triangle
    {
        public TTrianglePrizm(double h ,double a, double b, double c, double p) : base(a, b, c, p)
        {
        }


       
        // Площа
        new public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // периметр
        new public double Perimeter()
        {
            return a + b + c;
        }

        //Порівняння трикутників
        public static bool operator ==(TTrianglePrizm tr1, TTrianglePrizm tr2)
        {
            return tr1.a == tr2.a && tr1.b == tr2.b && tr1.c == tr2.c;
        }

        // Перевантаження операції +
        public static TTrianglePrizm operator +(TTrianglePrizm triangle, double num)
        {
            return new TTrianglePrizm(triangle.a + num, triangle.b + num, triangle.c + num);
        }

        // Перевантаження операції-
        public static TTrianglePrizm operator -(TTrianglePrizm triangle, double num)
        {
            return new TTrianglePrizm(triangle.a - num, triangle.b - num, triangle.c - num);
        }

        // Перевантаження операції *
        public static TTrianglePrizm operator *(TTrianglePrizm triangle, double num)
        {
            return new TTrianglePrizm(triangle.a * num, triangle.b * num, triangle.c * num);
        }
    }
}
