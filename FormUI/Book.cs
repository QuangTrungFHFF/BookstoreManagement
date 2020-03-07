using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Book
    {
        public string ProductID { get; set; }
        public string BookID { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Isbn { get; set; }

        public Book(string productID, string bookID, string gender, string title, string author, string publisher, int year, string isbn)
        {
            this.ProductID = productID;
            this.BookID = bookID;
            this.Gender = gender;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Year = year;
            this.Isbn = isbn;
        }
        public override bool Equals(object obj)
        {
            var that = (Book)obj;
            return this.Isbn.Equals(that.Isbn, StringComparison.OrdinalIgnoreCase);
        }
    }
}
