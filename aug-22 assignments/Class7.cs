using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_22_assignment
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "oracle");
            ht.Add(2, "vb.net");
            ht.Add(3, "cs.net");
            ht.Add(4, "asp.net");
            
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
            Console.WriteLine("after removing");
            ht.Remove(1);
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

        }
    }
}
