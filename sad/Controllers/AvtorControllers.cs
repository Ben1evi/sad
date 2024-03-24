using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using sad.Models;

namespace sad.Controllers
{
    public class AvtorsController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Avtor> avtors = new List<Avtor>
            {
                new Avtor { Name = "Иван", LastName = "Иванов", BirthYear = 1980, Psevdonim = "Псевдоним 1" },
                new Avtor { Name = "Петр", LastName = "Петров", BirthYear = 1975, Psevdonim = "Псевдоним 2" },
                new Avtor { Name = "Сидор", LastName = "Сидоров", BirthYear = 1990, Psevdonim = "Псевдоним 3" }
            };
            return View(avtors);
        }
    }
}
