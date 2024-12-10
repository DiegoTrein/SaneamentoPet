using Microsoft.EntityFrameworkCore;
using SaneamentoPet.Models;

namespace SaneamentoPet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pet> Pets { get; set; }
    }
}
