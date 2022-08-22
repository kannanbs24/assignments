using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_22_assignment
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the array size");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter the element-{0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            Console.WriteLine(" sum of printing array");
            foreach (var item in arr)
            {
                sum += item;
                

            }
            Console.WriteLine(sum);
        }
    }
    }

