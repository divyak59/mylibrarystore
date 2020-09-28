using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyLibraryStore.Models;
using MyLibraryStore.Repository;

namespace MyLibraryStore.controllers
{
    public class BooksController : Controller
    {
        private IBookRepository _bookRepos = null;
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookRepos.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.AddBook(book);

            return RedirectToAction("Index", "Books");
        }
        public IActionResult Update(Book book)
        {
            return View();
        }

        [HttpPut]
        public IActionResult Update(int? id, Book book)
        {
            if (id == null || book == null)
            {
                return BadRequest(nameof(book));
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var movieInDb = DbContext.book.SingleOrDefault(m => m.Id == id.Value);
            if (movieInDb == null)
            {
                return NotFound();
            }

            private IEnumerable<SelectListItem> GetGenres()
            {
                return new SelectListItem[]
                {
              new SelectListItem() { Text = "Not set", Value = string.Empty },
              new SelectListItem() { Text = "Action", Value = "Action" },
              new SelectListItem() { Text = "RomCom", Value = "RomCom" },
              new SelectListItem() { Text = "Animation", Value = "Animation" }
                 };
            }

        }
    }
}
