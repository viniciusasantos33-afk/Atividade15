using Atividade15.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade15.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Diretor> Diretores { get; set; }
    public DbSet<Genero> Generos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Filme>()
            .HasOne(f => f.Diretor)
            .WithMany(d => d.Filmes)
            .HasForeignKey(f => f.DiretorId);

        modelBuilder.Entity<Filme>()
            .HasMany(f => f.Generos)
            .WithMany(g => g.Filmes);
    }
}