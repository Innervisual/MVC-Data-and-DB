using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MVC_Data.Models
{
    public class City
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public IEnumerable<Person> People { get; set; }
        [Key]
        public int Id { get; set; }
        internal bool Contains(object obj)
        {
            return People.Contains(obj);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
