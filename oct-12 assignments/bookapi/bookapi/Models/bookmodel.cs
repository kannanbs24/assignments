using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookapi.Models
{
    public class bookmodel
    {
        private int _bookid;

        public int book_id
        {
            get { return _bookid; }
            set { _bookid = value; }
        }

        private string _bookname;

        public string book_name
        {
            //20
            get { return _bookname; }
            set
            {
                if ((value.Length > 20) || (string.IsNullOrEmpty(value)))
                {
                    throw new Exception(" it shud not exceed 10 chars");
                }
                else
                {
                    _bookname = value;
                }

            }
        }



        private string _bookauthor;

        public string book_author
        {

            get { return _bookauthor; }
            set
            {
                if ((value.Length > 20) || (string.IsNullOrEmpty(value)))
                {
                    throw new Exception(" it shud not exceed 10 chars");
                }
                else
                {
                    _bookauthor = value;
                }

            }
        }
       


    }
}