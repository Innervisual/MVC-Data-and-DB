using Microsoft.AspNetCore.Mvc;
using MVC_Data.Models;

namespace MVC_Data.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListOfPeople()
        {
            //Send List of persons to view
            ViewBag.LinkableId = PeopleViewModel.listOfPersons;

            //display list of people

            //The table data should come from a view model, which should have a list of people, and
            //the search phrase if one exists.

            return View(PeopleViewModel.listOfPersons);
        }



        [HttpPost]
        public IActionResult ListOfPeople(string searchTerm, string personName, string personCity, int personPhoneNumber, int personId)
        {
            ViewBag.LinkableId = PeopleViewModel.listOfPersons;
            //Searchpart 
            if (searchTerm != null)
            {
                PeopleViewModel.listOfPersonsFiltered.Clear();
                foreach (Person person in PeopleViewModel.listOfPersons)
                {

                    if (person.Name.ToLower().Contains(searchTerm.ToLower()) || person.City.ToLower().Contains(searchTerm.ToLower()))
                    {
                        PeopleViewModel.listOfPersonsFiltered.Add(person);
                    }
                }
                ViewBag.LinkableId = PeopleViewModel.listOfPersonsFiltered;

            }
            //add person
            else if (personName != null && personCity != null && personPhoneNumber != null && personId != null)
            {
                Person createdPerson = new Person { Name = personName, City = personCity, PhoneNumber = personPhoneNumber, Id = personId };
                PeopleViewModel.listOfPersons.Add(createdPerson);
                ViewBag.LinkableId = PeopleViewModel.listOfPersonsFiltered;
            }
            //Filter out persons
            return View(PeopleViewModel.listOfPersons);
        }
    }
}
