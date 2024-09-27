using Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Data
{
    public class AppDbContext: DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){
        }
        public DbSet<Producto> Productos  { get; set; }
    }
}
