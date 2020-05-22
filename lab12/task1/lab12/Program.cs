using System;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            TDate d1 = new TDate(10, 3, 2020);
            Console.WriteLine($"Попередня дата -{d1}");
            Console.WriteLine(d1['d']);                 // вихід за індексом

            // зміна значення за індексом
            d1['y'] = 1945;
            d1['m'] = 12;

            Console.WriteLine($"Змiнена дата -{d1}");
            Console.WriteLine("");

            // Для додавання д / м / у до дати
            Console.WriteLine("Що ви хочете змiнити: день(d), мiсяць(m) чи рiк(r)?");
            char choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Скiльки  {choice} ви хочете додати? ");
            int add = Convert.ToInt32(Console.ReadLine());

            d1.ChangeDate(ref d1, choice, add);
            Console.WriteLine(d1);

        }
    }
}
