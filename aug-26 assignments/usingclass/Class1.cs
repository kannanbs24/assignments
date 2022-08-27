using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingclass
{
    public struct Student
    {
        public int Id;
        public string Name;
        public int Fees;

        public void SetStudent(int id, string name, int fees)
        {
            Id = id;
            Name = name;
            Fees = fees;
        }
        public void get()
        {
            Console.WriteLine("enter id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            Name = Console.ReadLine();
            Console.WriteLine("emter fees");
            Fees = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintStudent()
        {
            Console.WriteLine("Student details:");
            Console.WriteLine("\tID     : " + Id);
            Console.WriteLine("\tName   : " + Name);
            Console.WriteLine("\tFees   : " + Fees);
            Console.WriteLine("\n");
        }
    }
    public class Class_stud
    {
        public int id;
        public string Name;
        public int Age;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string SName
        {
            get { return Name; }
            set { Name = value; }
        }
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public  void gett()
        {
            Console.WriteLine("Enter id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            SName = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            age = Convert.ToInt32(Console.ReadLine());

        }
        public  void puts()
        {
            Console.WriteLine("Following are the details");
            Console.WriteLine("id: "+Id);
            Console.WriteLine("name: "+SName);
            Console.WriteLine("age: "+age);
        }
    }
    public class product
    {
        public int _productID;

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        public string _productname;

        public string Productname
        {
            get { return _productname; }
            set { _productname = value; }
        }
        public static void ll()
        {
            List<int> productIDlist = new List<int>();
            List<string> producnamelist = new List<string>();
            Console.WriteLine("adding numbers");
            Console.WriteLine("----------");
            productIDlist.Add(1);
            productIDlist.Add(2);
            productIDlist.Add(3);
            //productIDlist.Add(3);
            Console.WriteLine("adding strings");
            Console.WriteLine("----------------");
            producnamelist.Add("kannan");
            producnamelist.Add("deepak");
            producnamelist.Add("dharsan");
            foreach (var i in productIDlist)
            {
                Console.WriteLine(i);
            }
            foreach (var j in producnamelist)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("removing numers");
            Console.WriteLine("------------------");
            int Remove = 1;
            productIDlist.Remove(Remove);
            foreach (var i in productIDlist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("removing string");
            Console.WriteLine("------------------");
            string remove = "kannan";
            producnamelist.Remove(remove);
            foreach (var item in producnamelist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        

    }
}
