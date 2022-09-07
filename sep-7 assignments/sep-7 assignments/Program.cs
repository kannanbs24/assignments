using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using static sep_7_assignments.Program;

namespace sep_7_assignments
{
    internal class Program
    {
        public delegate string stren5(string spo, string spo1);
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the string");
            string m = Console.ReadLine();
            strin s1 = new strin();
            ss1 s2 = new ss1(s1.lengthofstring);
            s2(m);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter username");
            string g = Console.ReadLine();
            ss1 s3 = new ss1(s1.greet);
            s3(g);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the two numbers");
            int yu = Convert.ToInt32(Console.ReadLine());
            int uy = Convert.ToInt32(Console.ReadLine());
            integer mi = new integer();
            ss2[] d3 = new ss2[3] { mi.Add, mi.Sub, mi.Multiply };
            ss2 d4 = (ss2)MulticastDelegate.Combine(d3);
            d4(yu, uy);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enter productId and product name");
            Products mo = new Products();
            mo.PId = Convert.ToInt32(Console.ReadLine());
            mo.Name = Console.ReadLine();
            ss3 poi = new ss3(mo.Display);
            poi(mo);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the year,Month,date");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int date = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            DateTime t = new DateTime(year, month, date);
            emp.Joining = t;

            ss4 se = new ss4(emp.Expyrs);
            int poiu = se(emp.Joining);
            Console.WriteLine($"Years of exp {poiu}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter strings to Concatenate");
            string yum = Console.ReadLine();
            string muy = Console.ReadLine();
            stren5 dpo = delegate (string so, string su)
            {
                return so + su;
            };
            string sod = dpo(yum, muy);
            Console.WriteLine($"Concatenated string is {sod}");
            Console.ReadLine();
            ups up = new ups();
            MyDelegate my = new MyDelegate(up.welcome);
            my();
        }
    }
}

