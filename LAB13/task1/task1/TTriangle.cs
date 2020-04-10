﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
     class TTriangle
    {
        private const double Epsilon = 0.0001;
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set
            {
                if (value < 0)
                    throw new Exception("Сторона має додатнє число");
                a = value;
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value < 0)
                    throw new Exception("Сторона має додатнє число");
                b = value;
            }
        }

        public double C
        {
            get { return c; }
            set
            {
                if (value < 0)
                    throw new Exception("Сторона має додатнє число");
                c = value;
            }
        }

        public TTriangle(double userA, double userB, double userC)
        {
            A = userA;
            B = userB;
            C = userC;
        }

        public override string ToString()
        {
            return $"a = {a}, b = {b}, c = {c}";
        }

        // Конструктор копіювання
        public TTriangle(TTriangle previousTriangle)
        {
            
            A = previousTriangle.a;
            B = previousTriangle.b;
            C = previousTriangle.c;
        }

        // Площа
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // периметр
        public double Perimeter()
        {
            return a + b + c;
        }

        //Порівняння трикутників
      
        public static bool operator ==(TTriangle tr1, TTriangle tr2)
        {
            return (Math.Abs(tr1.a - tr2.a) < Epsilon && Math.Abs(tr1.b - tr2.b) < Epsilon && Math.Abs(tr1.c - tr2.c) < Epsilon);
        }

        public static bool operator !=(TTriangle tr1, TTriangle tr2)
        {
            return !(tr1 == tr2);
        }
        // Перевантаження операції +
        public static TTriangle operator +(TTriangle triangle, double num)
        {
            return new TTriangle(triangle.a + num, triangle.b + num, triangle.c + num);
        }

        // Перевантаження операції-
        public static TTriangle operator -(TTriangle triangle, double num)
        {
            return new TTriangle(triangle.a - num, triangle.b - num, triangle.c - num);
        }

        // Перевантаження операції *
        public static TTriangle operator *(TTriangle triangle, double num)
        {
            return new TTriangle(triangle.a * num, triangle.b * num, triangle.c * num);
        }

    }
}
