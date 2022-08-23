using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_23_assignments
{
    internal class Class1
    {
        static void Main(string[] args)
        {
           
                kannan ex = new kannan();

               int result= ex.sums(50, 20);
            Console.WriteLine("sum"+" "+result);
            }
        }
    
    class kannan
    {
        public int sums(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
