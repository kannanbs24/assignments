using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_19_assignmentss
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
        }
    }
}
