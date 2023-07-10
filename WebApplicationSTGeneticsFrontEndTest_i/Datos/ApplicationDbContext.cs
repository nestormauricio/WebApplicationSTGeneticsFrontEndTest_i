using Microsoft.EntityFrameworkCore;
using WebApplicationSTGeneticsFrontEndTest_i.Modelos;

namespace WebApplicationSTGeneticsFrontEndTest_i.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Animal> Animal { get; set; }
    }
}
