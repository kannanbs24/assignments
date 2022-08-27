using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingclass
{
    public class Class2
    {
        public static void linkedlist()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("kannan");
            list.AddLast("ram");
            list.AddBefore(list.Last, "deeapk");
            list.AddAfter(list.First, "dhoni");
            list.AddBefore(list.Last.Previous, "welcome");
            list.AddAfter(list.First.Next, "hello");
            LinkedListNode<string> foundnode = list.Find("ram");
            foundnode.Value = "rohit";
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
