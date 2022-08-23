using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_23_assignments
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("purchase" + (int)deptname.purchase);
            Console.WriteLine("sales" + (int)deptname.sales);
            Console.WriteLine("training" + (int)deptname.training);
            Console.WriteLine("account" + (int)deptname.account);

            
        }
        enum deptname
        {
            purchase = 1,
            sales,
            training,
            account

        }
    }
    }

