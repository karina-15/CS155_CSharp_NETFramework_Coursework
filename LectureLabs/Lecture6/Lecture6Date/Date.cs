using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Date
{
    class Date
    {
        int day;
        int year;
        int month;

        public Date() {
            this.month = 1;
            this.day = 1;
            this.year = 1900;
}
        public Date(int month, int day, int year) {
            this.month = month;
            this.day = day;
            this.year = year;
}
        public Date(int year) {
            this.month = 1;
            this.day = 1;
            this.year = year;

}
        public Date(Date date) {
            this.day = date.day;
            this.month = date.month;
            this.year = date.year;
}
        public int getDay()
        {
            return day;
        }

        public int getMonth()
        {
            return month;
        }

        public int getYear()
        {
            return year;
        }

        public void setDay(int newDay)
        {
            day = newDay;
        }

        public void setMonth(int newMonth)
        {
            month = newMonth;
        }

        public void setYear(int newYear)
        {
            year = newYear;
        }

        public string dateString()
        {
            return String.Format("{0}/{1}/{2}", this.month, day, year);
        }

        public String MonthString()
        {
            switch(this.month)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                default:
                    return "None";
            }
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}/{2}", month, day, year);
        }

    }
}
