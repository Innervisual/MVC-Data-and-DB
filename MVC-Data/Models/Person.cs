using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Data.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string City { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Key]
        public int Id { get; set; }

        internal bool Contains()
        {
            throw new NotImplementedException();
        }
    }

}
