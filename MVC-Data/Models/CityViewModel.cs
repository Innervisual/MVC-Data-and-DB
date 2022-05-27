using System.Collections.Generic;

namespace MVC_Data.Models
{
    public class CityViewModel
    {
        public static City Stockholm = new City { Name = "Stockholm", Id = 1 };
        public static City Göteborg = new City { Name = "Göteborg", Id = 2 };
        public static City Köping = new City { Name = "Köping", Id = 3 };

        public static List<City> listOfCities = new List<City>
        {
            Stockholm,
            Göteborg,
            Köping
        };

        //public static List<Person> listOfPersonsFiltered = new List<Person>();
    }
}
