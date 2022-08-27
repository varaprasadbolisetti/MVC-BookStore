using Bookstore.Contracts;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class BookController : Controller
    {
        private IBooksService BooksService { get; }
        public BookController(IBooksService booksService)
        {
            BooksService = booksService;
        }
        public IActionResult Index()
        {
            var books =BooksService.GetBooks();
            return View(books);
        }

        [HttpPost]
        public JsonResult AddBook([FromBody]Book book)
        {
            return Json(BooksService.AddBook(book));

            
        }
        [HttpPost]
        public string delete(int bookId)
        {
            return BooksService.deletebook(bookId);
        } 
    }
}
