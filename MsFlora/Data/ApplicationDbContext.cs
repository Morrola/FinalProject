using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;  // This reference is usually used for authentication purposes, so make sure it’s necessary here.
using MsFlora.Models;  // Ensure this namespace points to your models (e.g., Product, Order, Customer).

namespace MsFlora.Data
{
    public class ApplicationDbContext : DbContext
    {
        

        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

       public DbSet<User> Users { get; set; }
        public DbSet<Testiomonial> Tests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Services> Services { get; set; }
        
    }
}
