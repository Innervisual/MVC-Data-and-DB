using Microsoft.AspNetCore.Mvc;
using MVC_Data.Data;
using MVC_Data.Models;
using System.Linq;

namespace MVC_Data.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listOfPerson = _context.People.ToList();

            return View(listOfPerson);
        }

        public IActionResult ListOfPeople()
        {
            //Send List of persons to view
            ViewBag.LinkableId = PeopleViewModel.listOfPersons;

            //display list of people

            //The table data should come from a view model, which should have a list of people, and
            //the search phrase if one exists.

            //return View(PeopleViewModel.listOfPersons);
            return View(_context.People.ToList());
        }



        [HttpPost]
        public IActionResult ListOfPeople(string searchTerm, string personName, string personCity, int? personPhoneNumber, int? personId)
        {
            ViewBag.LinkableId = PeopleViewModel.listOfPersons;
            //Searchpart 
            if (searchTerm != null)
            {
                PeopleViewModel.listOfPersonsFiltered.Clear();
                foreach (Models.Person person in PeopleViewModel.listOfPersons)
                {

                    if (person.Name.ToLower().Contains(searchTerm.ToLower()) || person.City.Name.ToLower().Contains(searchTerm.ToLower()))
                    {
                        PeopleViewModel.listOfPersonsFiltered.Add(person);
                    }
                }
                ViewBag.LinkableId = PeopleViewModel.listOfPersonsFiltered;

            }



            //add person
            else if (personName != null && personCity != null && personPhoneNumber != null && personId != null)
            {
                var FoundCity = (from City in _context.City
                                 where City.Name.ToLower().Contains(personCity.ToLower())
                                 select City).First();

                Models.Person createdPerson = new Models.Person { Name = personName, City = FoundCity, PhoneNumber = (int)personPhoneNumber };
                PeopleViewModel.listOfPersons.Add(createdPerson);

                //_context.Database.OpenConnection();
                //_context.Database.ExecuteSqlRaw(@"SET IDENTITY_INSERT [JPMVCdataDB].[dbo].[City] ON");
                //_context.Database.ExecuteSqlRaw(@"SET IDENTITY_INSERT [JPMVCdataDB].[dbo].[People] ON");

                _context.People.Add(createdPerson);
                _context.SaveChanges();
                ViewBag.LinkableId = PeopleViewModel.listOfPersonsFiltered;
            }
            //Filter out persons
            //return View(PeopleViewModel.listOfPersons);
            return View(_context.People.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]

        public IActionResult Delete(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
