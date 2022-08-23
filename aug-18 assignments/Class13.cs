using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            double fahrenheit;

            double celsius;
            Console.WriteLine("enter the value of celsius");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
        }
    }
}
