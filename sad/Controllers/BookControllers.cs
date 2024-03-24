using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using sad.Models;

namespace sad.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Book> books = new List<Book>
            {
                new Book { Title = "Книга 1", Year = 2000, Author = "Иван Иванов", Language = "Русский" },
                new Book { Title = "Книга 2", Year = 2010, Author = "Петр Петров", Language = "Английский" },
                new Book { Title = "Книга 3", Year = 2020, Author = "Сидор Сидоров", Language = "Французский" }
            };
            return View(books);
        }
    }
}
