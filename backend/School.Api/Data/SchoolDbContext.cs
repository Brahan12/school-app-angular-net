using Microsoft.EntityFrameworkCore;
using School.Api.Models;

namespace School.Api.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Nota> Notas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Profesor)
                .WithMany()
                .HasForeignKey(n => n.IdProfesor);

            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Estudiante)
                .WithMany()
                .HasForeignKey(n => n.IdEstudiante);
        }
    }
}
