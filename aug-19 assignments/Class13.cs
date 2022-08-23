using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_19_assignmentss
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the inuput");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n == 0)
            {
                case true:
                    Console.WriteLine("given inuput is zero");
                    break;

                case false:
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("given input is even");
                    }
                    else
                    {
                        Console.WriteLine("given input is odd");
                    }
                    break;

            }
        }
    }
}
