using ClassLibrary1;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> products { get; set; }
    public DbSet<ProductCategory> productCategories { get; set; }
    public DbSet<Orders> Orders { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(30);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Settings1.Default.Connection);
    }
}