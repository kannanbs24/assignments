using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            double usd = 0;
            double inr = 0;
            double value = 0;

            Console.WriteLine("Enter amount in USD: ");
            usd = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the USD value :");
            value = Convert.ToDouble(Console.ReadLine());

            inr = usd * value;
            Console.WriteLine("USD " + usd + "-> INR " + inr);
        }
    }
}
