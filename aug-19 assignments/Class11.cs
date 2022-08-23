using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_19_assignmentss
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 100; i <= 200; i++)
            {

                if (i % 9 == 0)
                {
                    Console.WriteLine("{0}  ", i);
                    sum += i;
                }
            }
            Console.WriteLine("the sum of 100 to 200 is,divisible by 9" + " " + sum);
        }
    }
}
