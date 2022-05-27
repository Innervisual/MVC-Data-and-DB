using Microsoft.EntityFrameworkCore;
using MVC_Data.Models;

namespace MVC_Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        public DbSet<City> City { get; set; }

    }
}
