using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("enter the first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("\nAfter Swapping : ");
            Console.WriteLine("\nFirst Number : " + number1);
            Console.WriteLine("\nSecond Number : " + number2);
        }
    }
}
