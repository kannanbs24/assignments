using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_23_assignments
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.getdata();
            obj.ShowData();
        }
    }
    public struct Employee
    {
        public int EmpID;
        public string empName;
        public int sal;
        public int depno;

        public Employee(int ID, string name, int salary, int dep)
        {
            EmpID = ID;
            empName = name;
            sal = salary;
            depno = dep;
        }
        public void getdata()
        {
            Console.WriteLine("enter the emid");
            EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the enpname");
            empName = Console.ReadLine();
            Console.WriteLine("enter the sal");
            sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the depno");
            depno = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.WriteLine("Employee ID=" + EmpID);
            Console.WriteLine("Employee Name=" + empName);
            Console.WriteLine("Employee sal=" + sal);
            Console.WriteLine("Employee dep.no.=" + depno);

        }
    }

}