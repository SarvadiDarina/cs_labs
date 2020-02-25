using System;


namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмір масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] numArray = new double[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("[{0}] номер: ", i);
                numArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            double[] resArray = new double[size];
            for (int i = 0, j = 0; i < size; i++)
            {
                if (Math.Abs(numArray[i]) > 1)
                    resArray[j++] = numArray[i];
            }
            foreach (double element in resArray)
                Console.Write("{0};  ", element);
        }
    }
}