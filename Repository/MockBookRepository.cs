using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace MyLibraryStore.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public void AddBook(Book book)
        {
           // throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            //throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
               new Book{Id=1, BookName="Alchemist",Author="Paulo Coelho",ISBN="IS65432",PublishedDate=Convert.ToDateTime("5/5/2008")},
               new Book{Id=2, BookName="Half Blood Prince",Author="J.K.Rowling",ISBN="IS23456",PublishedDate=Convert.ToDateTime("8/3/2001")},
               new Book{Id=3, BookName="Twilight Eclipse",Author="Stephanie Meyer",ISBN="IS87654",PublishedDate=Convert.ToDateTime("4/7/2005")},
               new Book{Id=4, BookName="Romeo and Juliet",Author="Shakespeare",ISBN="IS34587",PublishedDate=Convert.ToDateTime("12/23/1998")},
            };
        }   
        
    }

}
