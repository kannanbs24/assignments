﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace sep_5_assignments
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Cart c = new Cart();
            c.AcceptData();
            c.AcceptData();
            List<Book> Blist = new List<Book>();
            Blist = c.BooksList();

            foreach (var i in Blist)
            {
                Console.WriteLine("Book ID: " + i.BookID);
                Console.WriteLine("Book Name: " + i.BookName);
                Console.WriteLine("Book Price: " + i.BookPrice);
                c.BookCount();
            }
            Console.ReadLine();
        }
    }
}
