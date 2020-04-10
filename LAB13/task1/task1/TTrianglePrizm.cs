using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class TTrianglePrizm : TTriangle
    {
        private double h;

        public double H
        {
            get { return h; }
            set
            {
                if (value < 0)
                    throw new Exception("Сторона має додатнє число");
                h = value;
            }
        }
        public TTrianglePrizm(double a, double b, double c, double h) : base(a, b, c)
        {
            H = h;
        }
        public double Volume()
        {
            return base.Area() * h;
        }
        new double Area()
        {
            return base.Perimeter() * h + 2 * base.Area();
        }
        public TTrianglePrizm(TTrianglePrizm previousTTrianglePrizm)
        {

            A = previousTTrianglePrizm.A;
            B = previousTTrianglePrizm.B;
            C = previousTTrianglePrizm.C;
            H = previousTTrianglePrizm.h;
        }
        // Перевантаження операції +
        public static TTrianglePrizm operator +(TTrianglePrizm triangle, double num)
        {
            return new TTrianglePrizm (triangle.A + num, triangle.B + num, triangle.C + num, triangle.h + num);
        }

        // Перевантаження операції-
        public static TTrianglePrizm operator -(TTrianglePrizm triangle, double num)
        {
            return new TTrianglePrizm (triangle.A - num, triangle.B - num, triangle.C - num, triangle.h - num);
        }

        // Перевантаження операції *
        public static TTrianglePrizm operator* (TTrianglePrizm triangle, double num)
        {
            return new TTrianglePrizm (triangle.A * num, triangle.B * num, triangle.C * num, triangle.h * num);
        }
    }
}
