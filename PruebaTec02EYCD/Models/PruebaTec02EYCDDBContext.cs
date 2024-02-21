using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PruebaTec02EYCD.Models
{
    public partial class PruebaTec02EYCDDBContext : DbContext
    {
        public PruebaTec02EYCDDBContext()
        {
        }

        public PruebaTec02EYCDDBContext(DbContextOptions<PruebaTec02EYCDDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Directore> Directores { get; set; } = null!;
        public virtual DbSet<Pelicula> Peliculas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Directore>(entity =>
            {
                entity.HasKey(e => e.IdDirectores)
                    .HasName("PK__Director__B32A25B9A066D35E");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.HasKey(e => e.IdPelicula)
                    .HasName("PK__Pelicula__60537FD0188C6C4F");

                entity.Property(e => e.Genero)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sinopsis).IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDirectoresNavigation)
                    .WithMany(p => p.Peliculas)
                    .HasForeignKey(d => d.IdDirectores)
                    .HasConstraintName("FK__Peliculas__IdDir__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
