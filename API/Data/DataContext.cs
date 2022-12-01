using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
    // public DbSet<Nutritionist> Nutritionists { get; set; }
    // public DbSet<Role> Roles { get; set; }
    // public DbSet<Client> Clients { get; set; }
    public DbSet<Measurement> Measurements { get; set; }
}