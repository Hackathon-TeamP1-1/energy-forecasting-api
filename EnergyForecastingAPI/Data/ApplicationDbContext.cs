using Microsoft.EntityFrameworkCore;
using EnergyForecastingAPI.Models;

namespace EnergyForecastingAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
