using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Manufacturer
    {
        private string name;
        private DateTime foundation;
        private int phoneNumber;
        private int productionVolume;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Foundation
        {
            get { return foundation; }
            set { foundation = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public int ProdutionVolume
        {
            get { return productionVolume; }
            set { productionVolume = value; }
        }


        public Manufacturer(string name, DateTime foundation, int phoneNumber, int productionVolume)
        {
            Name = name;
            Foundation = foundation;
            PhoneNumber = phoneNumber;
            ProdutionVolume = productionVolume;
        }

        public override string ToString()
        {
            return $"Iм'я: {name}\r\nФундація: {foundation}\r\n" +
                   $"Номер телефону: {phoneNumber}\r\n" +
                    $"Обсяги продажу: {productionVolume}";
        }
    }
}
