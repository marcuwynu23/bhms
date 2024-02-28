using BHMS.Models;
using Microsoft.EntityFrameworkCore;

namespace BHMS.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    // Add DbSet properties here..
    public DbSet<User> Users { get; set; }
}
