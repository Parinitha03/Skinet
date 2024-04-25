using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        //One of the parameters provided to this constructor of StoreContext context class is a connection string.
        //In this proj, connection string is created in appsettings.dev.json
        {

        }

        public DbSet<Product> Products{ get; set;}
    }
}