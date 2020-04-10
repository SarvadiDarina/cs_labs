using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Owner
    {
        private string name;
        private int id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Owner(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return $"{name} - {id}";
        }
    }
}
