﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_23_assignments
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            employee e = new employee(1, "kannan", 1200, 1);
            Console.WriteLine("empid"+" "+e.emp_id);
            Console.WriteLine("emp_name"+" "+e.emp_name);
            Console.WriteLine("emp sal"+" "+e.sal);
            Console.WriteLine("emp_depno"+" "+e.depno);
         }
    }
    struct employee
    {
        public int emp_id;
        public string  emp_name;
        public int sal;
        public int depno;

        public employee(int emp_id,string emp_name,int sal,int depno)
        {
            this.emp_id = emp_id;
            this.emp_name= emp_name;    
            this.sal = sal; 
            this.depno= depno;
        }
    }

}
