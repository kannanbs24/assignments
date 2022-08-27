using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using usingclass;
namespace aug_26_assignments
{

    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("USING STRUCTURE");
            int n;
            Console.WriteLine("ENTER THE N NUMBER OF STUDENT");
            n = Convert.ToInt32(Console.ReadLine());
            Student[] stu = new Student[n];

            for (int i = 0; i < n; i++)
            {
                stu[i] = new Student();
                stu[i].get();

                stu[i].PrintStudent();

            }


            Console.WriteLine("-------------------------");

            Console.WriteLine("USING CLASS");
            int n1;
            Console.WriteLine("ENTER THE N NUMBER OF STUDENT");
            n1 = Convert.ToInt32(Console.ReadLine());
           
            Class_stud[] s = new Class_stud[n1];
            for (int i = 0; i < s.Length; i++)
            {
              
                s[i] = new Class_stud();

                s[i].gett();
                s[i].puts();
            }

              

                 
                Console.WriteLine("------------------------------");
            Console.WriteLine("linked list features");
                Class2.linkedlist();
            Console.WriteLine("----------------------");
            Console.WriteLine("lined list product add and remove");
            product.ll();
          
          

            

        }
    }
}
