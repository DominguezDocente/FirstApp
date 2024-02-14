using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Date
    {
        private int _year;
        private int month;
        private int day;

        public Date(int year, int month, int day)
        {
            this._year = year;
            this.month = month;
            this.day = day;
        }
    }
}
