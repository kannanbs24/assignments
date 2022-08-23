using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_19_assignmentss
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            string s1 = "kannan";
            string s2;



            Console.WriteLine("Enter the second string : ");
            s2 = Console.ReadLine();

            if (s1.Equals(s2))

                Console.WriteLine("Both string are equal");
            else
                Console.WriteLine("string are not equal");
        }
    }
}
