using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("enter the first no");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second no");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third no");
            z = Convert.ToInt32(Console.ReadLine());

            int ans1 = (x + y) * z;
            int ans2 = x * y + y * z;
            Console.WriteLine("the value of (x+y).z" + " " + ans1);
            Console.WriteLine("the value of x.y+y.z" + " " + ans2);
        }
    }
}
