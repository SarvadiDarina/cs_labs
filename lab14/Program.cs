using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введiть кiлькiсть фiгур - ");
                int n = Convert.ToInt32(Console.ReadLine());

                TBody[] figyr = new TBody[n];
                Random rand = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < figyr.Length; i++)
                {
                    switch (rand.Next(1, 3))
                    {
                        case 1:
                            figyr[i] = new TParallelepiped(rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10));
                            break;
                        case 2:
                            figyr[i] = new TBall(rand.Next(1, 10));
                            break;
                    }
                }

                for (int i = 0; i < figyr.Length; i++)
                {
                    Console.WriteLine(figyr[i]);
                }
                //сума всіх фігур
                double sum = 0;
                for (int i = 0; i < figyr.Length; i++)
                {
                    sum += figyr[i].Area();
                }

                Console.WriteLine(" ");
                Console.WriteLine($"Сума = {sum}");
            }
            catch
            {
                Console.WriteLine("Повинно бути додатнiм!");
            }
        }
    }
}
