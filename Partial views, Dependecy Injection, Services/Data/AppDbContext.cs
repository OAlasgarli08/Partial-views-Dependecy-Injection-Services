using Microsoft.EntityFrameworkCore;
using Partial_views__Dependecy_Injection__Services.Models;

namespace Partial_views__Dependecy_Injection__Services.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<SliderBottom>  SlidersBottom { get; set; }
        public DbSet<SliderTop>  SlidersTop { get; set; }
    }
}
