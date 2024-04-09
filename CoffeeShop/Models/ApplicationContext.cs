using CoffeeShop.Controllers;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Lecture> Lesson { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
