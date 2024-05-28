using Microsoft.EntityFrameworkCore;
using T2_HERRERA_LUIS.Models;

namespace T2_HERRERA_LUIS.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {

        }

        public DbSet<Distribuidor> distribuidores { get; set; }
    }
}
