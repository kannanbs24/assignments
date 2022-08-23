using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_19_assignmentss
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int large;
            Console.WriteLine("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number : ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else large = c;
            Console.WriteLine("Largest number is {0}", large);
        }
    }
}
