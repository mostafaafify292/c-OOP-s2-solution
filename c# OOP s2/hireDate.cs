using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__OOP_s2
{
    internal struct hirestruct
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public hirestruct(int monthValue, int dayValue, int yearValue)
        {
            Month = monthValue;
            Day = dayValue;
            Year = yearValue;
        }
    
        
        public int theMonth
        {
            get { return Month; }

            set
            {
                if (value <= 12)
                    Month = value;
                else
                {
                    Console.WriteLine("invalidValueOnMonth");
                }

            }
            

        }
        public int theDay
        {
            get { return Day; }
            set
            {
                if (value > 0 && value <= 31) Day = value;
                else
                {                   
                        Console.WriteLine("invalidValueOnDay");  
                }

            }
        }


        public override string ToString()
        {
            return String.Format("{0}/{1}/{2}", Month, Day, Year);
        }
    }
}
