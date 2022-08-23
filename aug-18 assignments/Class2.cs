using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            double firstno, secondno, result;
            Console.WriteLine("enter the first no");
            firstno = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second no");
            secondno = Convert.ToDouble(Console.ReadLine());



            result = firstno + secondno;
            Console.WriteLine("{0} + {1} = {2}", firstno, secondno, result);

            result = firstno - secondno;
            Console.WriteLine("{0} - {1} = {2}", firstno, secondno, result);

            result = firstno * secondno;
            Console.WriteLine("{0} * {1} = {2}", firstno, secondno, result);

            result = (firstno) / (secondno);
            Console.WriteLine("{0} / {1} = {2}", firstno, secondno, result);

            int num1, num2, rem;
            Console.WriteLine("enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
        }
    }
}
