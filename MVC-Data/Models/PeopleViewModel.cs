using System.Collections.Generic;

namespace MVC_Data.Models
{
    public class PeopleViewModel
    {
        public static Person person1 = new Person { Name = "Fredrik", City = CityViewModel.Stockholm, PhoneNumber = 999, Id = 1 };
        public static Person person2 = new Person { Name = "Fredde", City = CityViewModel.Göteborg, PhoneNumber = 111, Id = 2 };
        public static Person person3 = new Person { Name = "Rally", City = CityViewModel.Köping, PhoneNumber = 666, Id = 3 };
        public static Person person4 = new Person { Name = "Jonte", City = CityViewModel.Göteborg, PhoneNumber = 123, Id = 4 };
        public static Person person5 = new Person { Name = "Frasse", City = CityViewModel.Köping, PhoneNumber = 123, Id = 5 };
        public static List<Person> listOfPersons = new List<Person>
        {
            person1,
            person2,
            person3,
            person4,
            person5
        };
        public static List<Person> listOfPersonsFiltered = new List<Person>();
    }
}
