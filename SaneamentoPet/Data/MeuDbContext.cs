using Microsoft.EntityFrameworkCore;
using SaneamentoPet.Models;

namespace SaneamentoPet.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) { }

        public DbSet<Pet> Pets { get; set; } // DbSet para a entidade Pet
    }
}