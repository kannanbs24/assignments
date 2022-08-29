using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_29_assignments
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            
            GenericsLinkedList<string> stringLinkedList = new GenericsLinkedList<string>(); 
            string str1 = "helo";
            string str2 = "hi";
            string str3 = "kanna";
            string str4 = "welcome";
            stringLinkedList.AddHead(str1);
            stringLinkedList.AddHead(str2);
            stringLinkedList.AddHead(str3);
            stringLinkedList.AddHead(str4);
            
            foreach (string s in stringLinkedList)
            {
                Console.WriteLine(s);
            }

           
            GenericsLinkedList<int> integerList = new GenericsLinkedList<int>();
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;

            integerList.AddHead(n1);
            integerList.AddHead(n2);
            integerList.AddHead(n3);

            foreach (int Intger in integerList)
            {
                Console.WriteLine(Intger);
            }


            Console.ReadKey();


        }
    }


   
    class GenericsLinkedList<T>
    {
        class LinkedlistNode
        {
            private LinkedlistNode next;
            private T item;

            public LinkedlistNode(T t)
            {
                next = null;
                item = t;

            }
            public LinkedlistNode Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
            public T Item
            {
                get
                {
                    return item;
                }
                set
                {
                    item = value;
                }
            }
        }
        private LinkedlistNode head;
        public GenericsLinkedList()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            LinkedlistNode node = new LinkedlistNode(t);
            node.Next = head;
            head = node;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedlistNode current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }

        }

    }
}

