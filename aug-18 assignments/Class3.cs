using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            float f1, f2, f3, f4;
            Console.WriteLine("enter the first no");
            f1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the second no");
            f2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the third no");
            f3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the fourth no");
            f4 = Convert.ToSingle(Console.ReadLine());

            double sum = f1 + f2 + f3 + f4;
            double ans = sum / 4;
            Console.WriteLine("the average of four numbers is" + " " + ans);
        }
    }
}
