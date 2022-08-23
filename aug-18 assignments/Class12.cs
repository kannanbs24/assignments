using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            double meter;
            double km = 0;
            Console.WriteLine("enter the meter");
            meter = Convert.ToDouble(Console.ReadLine());
            km = meter / 1000;
            Console.WriteLine(km + "km");
        }
    }
}
