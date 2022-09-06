using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Book
    {
       
        private int _bookid;
        public int BookID
        {
            get { return _bookid; }
            set { _bookid = value; }
        }

        private string _bookname;

        public string BookName
        {
            get { return _bookname; }
            set { _bookname = value; }
        }


        private int _bookprice;
        public int BookPrice
        {
            get { return _bookprice; }
            set { _bookprice = value; }
        }

        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public Book() { }
        public Book(int id, string name, int price, string author)
        {
        }
      
        public void InsertBook(int id, string name, int price)
        {
            this.BookID = id;
            this.BookName = name;
            this.BookPrice = price;
        }
      
        public void InsertBook(int id, string name, int price, string author)
        {
            this.BookID = id;
            this.BookName = name;
            this.BookPrice = price;
            this.Author = author;
        }
       
        public void InsertBook(int id, string name)
        {
            this.BookID = id;
            this.BookName = name;
        }
    }
    public class Novel : Book
    {
        int NoOfPages;
        public void InsertBook(int id, string name, int price, int noofpages)
        {
            this.BookID = id;
            this.BookName = name;
            this.BookPrice = price;
            this.NoOfPages = noofpages;
        }
    }
    public class BookCategory
    {
       

        private int _catid;
        public int CatID
        {
            get { return _catid; }
            set { _catid = value; }
        }
        private string _catname;

        public string CatName
        {
            get { return _catname; }
            set { _catname = value; }
        }

        private string _desc;
        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }
        public BookCategory() { }
        public BookCategory(int cid, string cname, string desc)
        {

        }
    }
    public class Cart : Book
    {
        
        private int _customerid;

        public int CustomerID
        {
            get { return _customerid; }
            set { _customerid = value; }
        }
        private int _bookid;

        public new int BookID
        {
            get { return _bookid; }
            set { _bookid = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public void AddToCart(int customerid, int bookid, int price)
        {
            this.CustomerID = customerid;
            this.BookID = bookid;
            this.Price = price;
        }
        int _bid, _p;
        private string _bname;
        public static List<Book> BookList = new List<Book>();
        public void DisplayBook()
        {
            _bid = base.BookID;
            _bname = base.BookName;
            _p = base.BookPrice;
            Console.WriteLine(_bid);
            Console.WriteLine(_bname);
            Console.WriteLine(_p);
        }
        public void AcceptData()
        {
            Book p = new Book();

            Console.WriteLine("Enter Book ID: ");
            p.BookID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Name: ");
            p.BookName = Console.ReadLine();

            Console.WriteLine("Enter Book Price: ");
            p.BookPrice = Convert.ToInt32(Console.ReadLine());

            InsertBook(p);
            Console.WriteLine("Book added successfully...");
        }
        public void InsertBook(Book BookData)
        {
            BookList.Add(BookData);
        }
        public List<Book> BooksList()
        {
            return BookList;
        }
        static int count;
        public void BookCount()
        {
            count = count + 1;
            Console.WriteLine("You added total Nos of Books: " + count);
        }
    }
}
