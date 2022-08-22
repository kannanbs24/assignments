using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_22_assignment
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            int x = 7;
            int y = 10;
            string d = "kannan";
            al.Add(x);
            al.Add(d);
            al.Add(y);

            foreach (object o in al)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("after removing");
            al.Remove(x);
            foreach (object o in al)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("count"+al.Count);
           
        }
    }
}
