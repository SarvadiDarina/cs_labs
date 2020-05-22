using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Я хочу знайти рiшення системи:\n 1)системи двох лiнiйних рiвнянь з двома невiдомими  \n " +
                "2) системи трьох лiнiйних рiвнянь з трьома невiдомими");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                double x1;
                double x2;

                Equation eq = new Equation();
                IMatrix2 eq2 = (IMatrix2)eq;
                eq2.SetValues(ref eq);
                eq2.Solution(out x1, out x2);
                Console.WriteLine();
                eq2.EquationOutput();
                Console.WriteLine();

                Console.WriteLine($"x = {x1}, y = {x2}");

            }
            else if (userChoice == 2)
            {
                double x1;
                double x2;
                double x3;

                Equation eq = new Equation();
                IMatrix3 eq3 = (IMatrix3)eq;
                eq3.SetValues(ref eq);
                eq3.Solution(out x1, out x2, out x3);
                Console.WriteLine();
                eq3.EquationOutput();

                Console.WriteLine($"x = {x1}, y = {x2}, z = {x3}");
            }
            else
            {
                Console.WriteLine("Спробуйте ще раз...");
            }
        }
    }
}
