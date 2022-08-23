using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_19_assignmentss
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Enter the first number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is greater than the second number");
            }
            else
            {
                Console.WriteLine("First number is smaller than the second number");
            }
        }
    }
}
