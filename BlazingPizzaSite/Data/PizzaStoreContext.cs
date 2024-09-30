using Microsoft.EntityFrameworkCore;

namespace BlazingPizzaSite.Data;

/// <summary>
/// Create database context that we can use to register a database service. Also allows having a controller to access the database
/// </summary>
public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}