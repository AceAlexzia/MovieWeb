using MovieWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieWeb.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options): base(options) 
        {

        }
        // Bring Model Movie to create database
        public DbSet<Movie> Movies { get; set; }
    }
}
