using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_18_assignmentss
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0} ", a);
                }
                Console.Write("\n");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}", a);
                }
                Console.Write("\n");
            }
        }
    }
}
