using Microsoft.EntityFrameworkCore;
using RolService.Models;

namespace RolService.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {}

    public DbSet<Role> Roles => Set<Role>();
}
