using System.Security.Cryptography;
using System.Text;
using Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options)
        : base(options) { }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<Shift> Shifts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var hmac = new HMACSHA512();
        modelBuilder
            .Entity<AppUser>()
            .HasData(
                new AppUser()
                {
                    Id = 1,
                    FirstName = "murat",
                    Surname = "muldashev",
                    Email = "admin@gmail.com",
                    Role = "Manager",
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Admin123")),
                    PasswordSalt = hmac.Key,
                    IsBarmen = false,
                    IsShishaMaster = false
                }
            );
    }
}
