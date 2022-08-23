using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_23_assignments
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("input first number");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input second number");
                int j = Convert.ToInt32(Console.ReadLine());
                int k = i / j;
                Console.WriteLine(k);


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("this is a divide by zero exception");
                Console.WriteLine(ex.Message);

            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("anyway printed");

            }
        }
    }
}
