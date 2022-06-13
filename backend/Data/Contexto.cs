using Microsoft.EntityFrameworkCore;
namespace backend.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        
    }
}