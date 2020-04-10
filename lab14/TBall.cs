using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class TBall : TBody
    {
        public TBall(int r) : base(r) { }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(Data, 2);
        }

        public override double Volume()
        {
            return (4 * Math.PI * Data) / 3;
        }

        public override string ToString()
        {
            return $"Куля: Радiус = {Data}";
        }
    }
}