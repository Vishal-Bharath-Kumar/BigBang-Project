using Microsoft.EntityFrameworkCore;

namespace Bigbang.Models
{
    public class BigbangDbContext : DbContext
    {
     
        public BigbangDbContext(DbContextOptions<BigbangDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public DbSet<LogIn> Logins { get; set; }

        public DbSet<Booking_Details> Booking_Details { get; set; }

    }
}