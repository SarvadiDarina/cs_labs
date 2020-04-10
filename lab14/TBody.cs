using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    public abstract class TBody
    {
        private protected int data;
        public int Data
        {
            get { 
                return data;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Повинно бути додатнiм!");
                data = value;
            }
        }
        public TBody(int data)
        {
            Data = data;
        }

        public abstract double Area();

        public abstract double Volume();
    }
}