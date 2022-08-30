using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_30_assignments
{
    internal class quick_sort
    {
        static void quicksort(int[] Array, int left, int right)
        {
            if (left < right)
            {
                int pivot = partition(Array, left, right);
                quicksort(Array, left, pivot - 1);
                quicksort(Array, pivot + 1, right);
            }
        }

        
        static int partition(int[] Array, int left, int right)
        {
            int i = left;
            int pivot = Array[right];
            int temp;

            for (int j = left; j <= right; j++)
            {
                if (Array[j] < pivot)
                {
                    temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = temp;
                    i++;
                }
            }

            temp = Array[right];
            Array[right] = Array[i];
            Array[i] = temp;
            return i;
        }

       
        static void PrintArray(int[] Array)
        {
            int n = Array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(Array[i] + " ");
            Console.Write("\n");
        }

       
        static void Main(string[] args)
        {
            int[] MyArray = { -4, 1, 25, 50, 8, 10, 23 };
            int n = MyArray.Length;
            Console.Write("Original Array\n");
            PrintArray(MyArray);

            quicksort(MyArray, 0, n - 1);
            Console.Write("\n quick Sorted Array\n");
            PrintArray(MyArray);
        }
    }
}
