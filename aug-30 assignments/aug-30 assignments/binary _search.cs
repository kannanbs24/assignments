using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_30_assignments
{
    internal class binary__search
    {
        public static int Find(int[] numList, int val)
        {

            int low = 0;
            int high = numList.Length - 1;
            int mid = 0;
            while (low <= high)
            {
                
                mid = high + low / 2;

                if (val == numList[mid])
                {
                   
                    return mid;
                }
                if (val > numList[mid])
                {
                  
                    low = mid + 1;

                  
                }
                else
                {
                   
                    high = mid - 1;
                }

            }

            return -1;

        }
    





    public static void Main()
    {
            Console.WriteLine(" ----binary search----");
        var location = binary__search.Find(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2);
        Console.WriteLine(location);

    }
   }
}
