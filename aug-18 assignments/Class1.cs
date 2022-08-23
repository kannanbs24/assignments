using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double d1, d2, d3;
            Console.WriteLine("enter the first number");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number");
            d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the third number");
            d3 = Convert.ToDouble(Console.ReadLine());
            double ans;
            ans = d1 * d2 * d3;
            Console.WriteLine("multiplication of three numbers is" + " " + ans);
        }
    }
}
