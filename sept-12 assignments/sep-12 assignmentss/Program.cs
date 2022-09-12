using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace sep_12_assignmentss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\c# assignment\\sep-12 assignmentss\\ClassLibrary1\\bin\\Debug\\ClassLibrary1.dll";
            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            Type t = null;

            foreach (var item in types)
            {
                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);
                item.InvokeMember("cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 10.0 });
                item.InvokeMember("sqrt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 10.0 });

            }

            Console.ReadLine();

            Console.WriteLine("-------------");
        }
    }
}
