using Microsoft.EntityFrameworkCore;
using WebAPILibros.Entidades;

namespace WebAPILibros.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<Autor> Autores { get; set; }
    }
}
