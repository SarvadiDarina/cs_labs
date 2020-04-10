using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class TParallelepiped : TBody
    {
        private int a;
        private int b;
        public int A
        {
            get { 
                return a; 
            }
            set
            {
                if (value < 0)
                    throw new Exception("Повинно бути додатнiм!");
                a = value;
            }
        }

        public int B
        {
            get { 
                
                return b; }
            set
            {
                if (value < 0)
                    throw new Exception("Повинно бути додатнiм!");
                b = value;
            }
        }

        public TParallelepiped(int a, int b, int side) : base(side)
        {
            A = a;
            B = b;
        }

        public override double Area()
        {
            double P = 2 * (a + b);
            double S = a * b;
            return P * Data + 2 * S;
        }

        public override double Volume()
        {
            return a * b * Data;
        }

        public override string ToString()
        {
            return $"Паралелепiпед: Cторони = {a}, {b}, {Data}";
        }

    }
}
