using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug_25_assignmets
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            string path = "E:\\c# assignment\\aug-25 assignmets\\aug-25 assignmets";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            /*     File.Create(path+fname);
                 Console.WriteLine("file created successfully...");    //file creation  */

           /* Console.WriteLine("Enter your file contents");
            string con = Console.ReadLine();
           
            File.WriteAllText(fname, con);
            Console.WriteLine("file created successfully with contents...");  */ // add contents


          /*  File.Copy(fname, "E:\\c# assignment\\aug-25 assignmets\\aug-25 assignmets\\democopy.txt");
            Console.WriteLine("copy succesfully");  */    //coopy

          
         /*   File.Move(fname, "E:\\c# assignment\\aug-25 assignmets\\aug-25 assignmets\\MovedFile.txt");
            Console.WriteLine(" Moved File Succesfully");   */  //move

            /* File.Delete(fname); */    //delete

            FileInfo fileInfo = new FileInfo(fname);
            Console.WriteLine("--------------");
            Console.WriteLine(fileInfo.FullName + "  Full Name");
            Console.WriteLine("--------------");
            Console.WriteLine(fileInfo.Extension + " Extension");
            Console.WriteLine("--------------");
            Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            Console.WriteLine("--------------");
            Console.WriteLine(fileInfo.CreationTime);   
           
        }
    }
}

    

