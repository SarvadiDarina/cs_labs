using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Angle = ");
            double angle = Convert.ToInt32(Console.ReadLine());
            double result = 0.5 * a * b * Math.Sin((angle * Math.PI) / 180);
            Console.WriteLine("Площа трикутника = {0}", result);
        }
    }
}
