using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa>? Pessoas { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("DefaultConnection");

    }
}