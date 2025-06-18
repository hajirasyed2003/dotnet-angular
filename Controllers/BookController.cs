using Microsoft.AspNetCore.Mvc;
using BookApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> bookList = new List<Book>();

        public IActionResult Index()
        {
            return View(bookList);
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            if (bookList.Any(b => b.Isbn == book.Isbn))
            {
                ModelState.AddModelError("Isbn", "ISBN must be unique.");
                return View(book);
            }

            bookList.Add(book);
            return RedirectToAction("Index");
        }
    }
}
