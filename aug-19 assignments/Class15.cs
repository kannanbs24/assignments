using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_19_assignmentss
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            int score = 100;
            string input;
            Console.WriteLine("enter the given input hit or miss");

            for (int i = 0; i <= 3; i++)
            {
                input = Console.ReadLine();
                if (input == "hit")
                {
                    score += 10;
                }
                else if (input == "miss")
                {
                    score -= 20;
                }
            }
            Console.WriteLine(score);
        }
    }
}
