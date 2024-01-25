// Data/ApplicationContext.cs
using Examen_backend.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class ApplicationContext : DbContext
{
    public DbSet<Profesor> Profesori { get; set; }
    public DbSet<Materie> Materii { get; set; }
    public DbSet<Asignare> Asignari { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asignare>()
            .HasKey(a => new { a.AsignareId });

        modelBuilder.Entity<Asignare>()
            .HasOne(a => a.Profesor)
            .WithMany(p => p.Asignari)
            .HasForeignKey(a => a.ProfesorId);

        modelBuilder.Entity<Asignare>()
            .HasOne(a => a.Materie)
            .WithMany(m => m.Asignari)
            .HasForeignKey(a => a.MaterieId);
    }
}
    