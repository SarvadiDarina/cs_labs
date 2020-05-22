
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace task1
    {
        interface IMatrix3
        {
            void SetValues(ref Equation mtrx);
            void EquationOutput();
            void Solution(out double x1, out double x2, out double x3);
        }
    }