using System;
using System.Collections.Generic;
using System.Text;

namespace lab12
{
    class TDate
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 0 || value > 31)
                    throw new Exception("День повинен бути в межах 1-31");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new Exception("Мiсяць повинен бути в дiапазонi 1-12");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0)
                    throw new Exception("Рiк повинен бути натуральним числом");
            }
        }

        public TDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // індексатор
        public int this[char indx]
        {
            get
            {
                switch (indx)
                {
                    case 'd': return Day;
                    case 'm': return Month;
                    case 'y': return Year;
                    default: return 0;
                }
            }

            set
            {
                switch (indx)
                {
                    case 'd':
                        Day = value;
                        break;
                    case 'm':
                        Month = value;
                        break;
                    case 'y':
                        Year = value;
                        break;
                }
            }
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public void ChangeDate(ref TDate date, char choice, int add)
        {
            if (choice == 'd')
                date = new TDate(this['d'] + add, Month, Year);
            else if (choice == 'm')
                date = new TDate(Day, this['m'] + add, Year);
            else if (choice == 'y')
                date = new TDate(Day, Month, this['y']);
            else
                date = this;
        }
    }
}
