using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void ss1(string s);
    public delegate void ss2(int i, int j);
    public delegate void ss3(Products p);
    public delegate int ss4(DateTime t);
    public delegate void MyDelegate();
    public class strin
    {
        public void lengthofstring(string s)
        {
            Console.WriteLine(s.Length);

        }
        public void greet(string s)
        {
            Console.WriteLine($"Hello {s}");
        }
    }
    public class integer
    {
        public void Add(int i, int j)
        {
            Console.WriteLine($"Addition is {i + j}");
        }
        public void Sub(int i, int j)
        {
            if (i > j)
            {
                Console.WriteLine($"Subtraction is {i - j}");
            }
            else
            {
                Console.WriteLine($"Subtraction is {j - i}");
            }
        }
        public void Multiply(int i, int j)
        {
            Console.WriteLine($"Multiplication is {j * i}");
        }

    }
    public class Products
    {
        public int PId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public void Display(Products p)
        {
            Console.WriteLine($"Product id is {p.PId} and name is {p.Name}");
        }
    }
    public class Employee
    {
        private DateTime _joining;
        public DateTime Joining
        {
            get { return _joining; }
            set { _joining = value; }

        }
        public int Expyrs(DateTime ji)
        {
            int p = DateTime.Now.Year - ji.Year;
            return p;
        }
    }
    public class ups
    {
        public void welcome()
        {
            Console.WriteLine(  "enter the char to upper");
            String str = Console.ReadLine(); 
            String result = str.ToUpper();
            Console.WriteLine("upper case "+ result);
        }
    }
}
