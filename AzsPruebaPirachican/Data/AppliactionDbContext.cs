using AzsPruebaPirachican.Data;
using AzsPruebaPirachican.Models;
using Microsoft.EntityFrameworkCore;

namespace AzsPruebaPirachican.Data
{
    public class AppliactionDbContext : DbContext
    {
        public AppliactionDbContext(DbContextOptions<AppliactionDbContext> options) : base(options)
        {

        }

        public DbSet<AutoresModel> Autores { set; get; } 
        public DbSet<LibrosModel>libros { set; get; }
    }
}
