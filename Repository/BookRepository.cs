using MyLibraryStore.Data;
using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    //step4
    public class BookRepository: IBookRepository
    {
        private ApplicationDbContext _dbContext = null;

        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == id);
            if(book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException(id.ToString());
            }

        }
        public void Update(int?id )
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == id);
            if (book != null)
            {
                _dbContext.Books.Update(book);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException(id.ToString());
            }

        }

        public Book GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }
        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }
    }
}
