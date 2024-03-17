using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class AppDbContext : DbContext
    {

        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
                Database.SetConnectionString("Server=DESKTOP-GFSB6QJ\\SQLEXPRESS;Database=ConsoleApp1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
                Database.EnsureCreated();

            var dbContext = new AppDbContext.ApplicationDbContext(options);
            }
            public DbSet<Order> Order { get; set; }

            public DbSet<Product> Product { get; set; }

            public DbSet<User> Users { get; set; }
        }
    }
}
