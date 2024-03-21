using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BookService
    {
        public List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
           books.Add(book);
        }
        public Book GetBook(string bookName)
        {
            return books.Single(x => x.Name == bookName);
        }
    }
}
