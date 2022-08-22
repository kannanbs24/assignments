using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_22_assignment
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            List<float> lst = new List<float>();
            lst.Add(100.12f);
            lst.Add(200.13f);
            lst.Add(500.43f);
            lst.Add(400.9f);
             foreach (float i in lst)
            {
                Console.WriteLine(i);
            }
             lst.Sort();
            Console.WriteLine("ascending");
            foreach (float i in lst)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("descending");
            lst.Reverse();
            foreach (float i in lst)
            {
                Console.WriteLine(i);
            }


        }
    }
}
