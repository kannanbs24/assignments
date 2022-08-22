using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_22_assignment
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            
                int n;
                Console.WriteLine("enter the array size");
                n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < arr.Length; i++)
                {
                   
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(arr);
                Console.WriteLine("printing array");
                Console.WriteLine("min"+" "+arr[0]);
                Console.WriteLine("max"+" " + arr[arr.Length-1]);
            }
    }
}
