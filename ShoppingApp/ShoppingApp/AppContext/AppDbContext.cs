using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models.Entity;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Country> Countries { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Users> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CountryEntityConfig());
        modelBuilder.ApplyConfiguration(new StateEntityConfig());
        modelBuilder.ApplyConfiguration(new CityEntityConfig());
        modelBuilder.ApplyConfiguration(new UsersEntityConfig());

        base.OnModelCreating(modelBuilder);
    }
}
