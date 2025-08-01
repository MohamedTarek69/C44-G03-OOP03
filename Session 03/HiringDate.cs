using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class HiringDate
    {
        #region Attributes
        private int day;
        private int month;
        private int year;
        #endregion

        #region Properties
        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;
                else
                    Console.WriteLine("Day must be between 1 and 31.");
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    Console.WriteLine("Month must be between 1 and 12.");
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    year = value;
                else
                    Console.WriteLine("Year must be between 1900 and the current year.");
            }
        }


        #endregion

        #region Constructor
        public HiringDate(int day, int month, int year)
        {
            Day=day;
            Month=month;
            Year=year;
        }

        #endregion
        
        #region Methods
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
        #endregion
    }
}
