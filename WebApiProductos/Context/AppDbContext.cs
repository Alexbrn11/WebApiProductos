using Microsoft.EntityFrameworkCore;
using WebApiProductos.Models;

namespace WebApiProductos.Context
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
            public DbSet<Product> Products { get; set; }
        }
}
