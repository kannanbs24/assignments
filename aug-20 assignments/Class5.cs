using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_22_assignment
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Sonoo");
            names.Push("Peter");
            names.Push("James");
            names.Push("Ratan");
            names.Push("Irfan");
            Console.WriteLine("before pop ");
            foreach (string name in names)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine(" before Peek element: " + names.Peek());
           names.Pop();

            Console.WriteLine("after pop");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(" after Peek element: " + names.Peek());

        }
    }
}
