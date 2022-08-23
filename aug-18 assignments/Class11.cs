using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            string s1 = "Hello C#";
            string s2 = "";
            bool b1 = string.IsNullOrEmpty(s1);
            bool b2 = string.IsNullOrEmpty(s2);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
