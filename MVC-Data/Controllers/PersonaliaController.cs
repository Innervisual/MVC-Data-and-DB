using Microsoft.AspNetCore.Mvc;
using MVC_Data.Data;
using MVC_Data.Models;
using System.Linq;

namespace MVC_Data.Controllers
{
    public class PersonaliaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonaliaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listOfPersonalias = _context.Personalias.ToList();

            return View(listOfPersonalias);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Personalia personalia)
        {
            if (ModelState.IsValid)
            {
                _context.Personalias.Add(personalia);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]

        public IActionResult Delete(Personalia personalia)
        {
            if (ModelState.IsValid)
            {
                _context.Personalias.Remove(personalia);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
