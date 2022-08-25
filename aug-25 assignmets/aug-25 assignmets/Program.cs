using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace aug_25_assignmets
{
    internal class Program
    {
        static void Main(string[] args)


        {
            do
            {

                Console.WriteLine("1.create\n 2.add\n 3.truncate\n");
                int x = Convert.ToInt32(Console.ReadLine());
                string path = "E:\\c# assignment\\aug-25 assignmets\\aug-25 assignmets";
                Console.WriteLine("Enter the file name");
                string fname = Console.ReadLine();


                fname = string.Concat(path, fname);
                Console.WriteLine("--------------------------------");
                // file creation path
                switch (x)
                {
                    case 1:



                        FileStream f = new FileStream(fname, FileMode.Create);
                        StreamWriter s = new StreamWriter(f);

                        s.WriteLine("hello c#");
                        s.Close();
                        f.Close();
                        Console.WriteLine("File created successfully...");
                        break;    //create

                    case 2:
                        Console.WriteLine("-----------------");

                        FileStream fs = new FileStream(fname, FileMode.Append);
                        StreamWriter ss = new StreamWriter(fs);

                        ss.WriteLine("hi kannan");
                        ss.Close();
                        fs.Close();
                        Console.WriteLine(" append  successfully...");
                        break;//append
                    case 3:
                        Console.WriteLine("-----------------------");
                        FileStream fs1 = new FileStream(fname, FileMode.Truncate);
                      
                       
                        fs1.Close();
                        Console.WriteLine(" truncate  successfully...");
                        break;//truncate



                }
            } while (true);

        }
    }
}
