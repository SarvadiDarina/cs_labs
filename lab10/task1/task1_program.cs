using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введiть число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Num n = new Num(number);

                Console.WriteLine($"Число: {n.ToString()}"); 
                Console.WriteLine($"Кiлькiть цифр: {n.CountOfNums()}");
                Console.WriteLine($"Сума цифр: {n.SumOfDigits()}");
            }

            catch
            {
                Console.WriteLine("Повинно бути додатнє ціле число");
            }
        }
    }
}
