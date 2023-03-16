using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_97
{
    internal class Book
    {
        public string book_title;
        public int book_pages;
        public int book_PublicationYear;

        public Book(string book_title, int book_pages, int book_PublicationYear) 
        {
            this.book_title = book_title;
            this.book_pages = book_pages;
            this.book_PublicationYear = book_PublicationYear;
        }
    }
}
