using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderesuablelibrary
{
   public class Class4
    {
        public static void upper()
        {
            String str = "Hello World";
           
            String result = str.ToUpper();
            Console.WriteLine($"Original String : {str}");
            Console.WriteLine($"Uppercase String : {result}");
        }

    }
}
