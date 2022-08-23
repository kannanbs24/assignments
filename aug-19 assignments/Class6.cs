using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_19_assignmentss
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the first subject");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second subject");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third subject");
            c = Convert.ToInt32(Console.ReadLine());
            int tot_mark = a + b + c;
            Console.WriteLine("total_marks=" + " " + tot_mark);
            float per = tot_mark / 3;
            if (per < 35)
            {
                Console.WriteLine("fail");
            }
            else if (per > 35 && per < 45)
            {
                Console.WriteLine("third ");
            }
            else if (per > 45 && per < 60)
            {
                Console.WriteLine("second ");
            }
            else
            {
                Console.WriteLine("first");
            }
        }
    }
}
