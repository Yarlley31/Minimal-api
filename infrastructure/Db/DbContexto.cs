using Microsoft.EntityFrameworkCore;
using MinimalApi.Domain.Entities;

namespace MinimailApi.Infrastructure.Db;
public class DbContexto : DbContext
{
    public DbSet<Administrator> Administrators { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("string de conexão", ServerVersion.AutoDetect("string de conexão"));
    }
}