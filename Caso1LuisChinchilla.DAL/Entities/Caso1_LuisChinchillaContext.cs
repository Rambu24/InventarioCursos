using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Caso1LuisChinchilla.DAL.Entities
{
    public partial class Caso1_LuisChinchillaContext : DbContext
    {
        public Caso1_LuisChinchillaContext()
        {
        }

        public Caso1_LuisChinchillaContext(DbContextOptions<Caso1_LuisChinchillaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InventarioCurso> InventarioCursos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventarioCurso>(entity =>
            {
                entity.HasKey(e => e.Indice)
                    .HasName("PK__Inventar__5B8BEAB66FA8BC74");

                entity.ToTable("Inventario_Cursos");

                entity.Property(e => e.CodigoAsignatura).HasColumnName("Codigo_Asignatura");

                entity.Property(e => e.Correo)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Creditos).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.Cuatrimestre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DuracionSemanas).HasColumnName("Duracion_Semanas");

                entity.Property(e => e.FechaFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Final");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Inicio");

                entity.Property(e => e.HorasSemanales)
                    .HasColumnType("decimal(2, 1)")
                    .HasColumnName("Horas_Semanales");

                entity.Property(e => e.NombreAsignatura)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Asignatura");

                entity.Property(e => e.NombreCarrera)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Carrera");

                entity.Property(e => e.NombreDocente)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Docente");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
