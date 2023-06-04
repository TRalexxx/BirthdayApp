using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace BirthdayApp
{
    public class MyApplicationContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=desktop-o6o2rko;Database=User_db;Trusted_Connection=True;TrustServerCertificate=True;");
        }
            
        
    }
}
