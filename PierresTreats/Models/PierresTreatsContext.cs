using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
    public class PierresTreatsContext : DbContext
    {
        public virtual DbSet<Flavor> Flavors { get; set; }
        public virtual DbSet<Treat> Treats { get; set; }
        public PierresTreatsContext(DbContextOptions options) : base(options) { }
    }
}