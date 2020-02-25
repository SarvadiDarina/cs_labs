using System;
using System.Linq;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмір масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Елемент [{0}] = ", i);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(nums.Min());
        }
    }
}