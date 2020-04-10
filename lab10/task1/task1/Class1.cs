using System;

namespace task1
{
    class Num
    {
        private int num;

        public int Number
        {
            get { return num; }
            set
            {
                if (value < 0)
                    throw new Exception("Повинно бути додатнє ціле число!");
                num = value;
            }
        }

        public Num(int userNum)
        {
            Number = userNum;
        }

        public override string ToString()
        {
            return $"{num}";
        }

        public int CountOfNums()
        {
            return num.ToString().Length;
        }

        public int SumOfDigits()
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}