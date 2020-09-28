using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
   public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetBookById(int Id);
        void AddBook(Book book);
        void Delete(int Id);
        void Update(int? id);

    }
}
