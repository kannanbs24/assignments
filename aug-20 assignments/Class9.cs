using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_22_assignment
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();

            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key+" "+kvp.Value );
            }
            dct.Remove(1);
            Console.WriteLine("after removing");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
  

 }
}

