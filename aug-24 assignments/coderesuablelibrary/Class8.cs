using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderesuablelibrary
{
    public class Class8
    {
        public static void age()
        {
              DateTime dt1 = new DateTime(2000,08,24);
              
                DateTime now = DateTime.Today;
                int age = now.Year - dt1.Year;
                if (dt1 > now.AddYears(-age))
                    age--;

                Console.WriteLine("age= "+age);
                Console.WriteLine("day = " + dt1.Day);
                Console.WriteLine("month = " +dt1.Month);
                Console.WriteLine("year = " + dt1.Year);
                Console.WriteLine("week = " + dt1.DayOfWeek);


                bool isLeapYear = DateTime.IsLeapYear(dt1.Year);
                Console.WriteLine("leap year->>>> "+isLeapYear);



                Console.ReadLine();   



        }
    }
}
