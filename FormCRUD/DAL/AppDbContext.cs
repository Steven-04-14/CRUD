using FormCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace FormCRUD.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Producto> Products {  get; set; }
    }
}
