using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EcoMapsAPI.Entidades;

public partial class EcoMapsContext : DbContext
{
    public EcoMapsContext()
    {
    }

    public EcoMapsContext(DbContextOptions<EcoMapsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ContResiduo> ContResiduos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContResiduo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ArticleId)
                .HasMaxLength(255)
                .HasColumnName("articleId");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.Codigo)
                .HasMaxLength(255)
                .HasColumnName("codigo");
            entity.Property(e => e.Latitud)
                .HasMaxLength(255)
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasMaxLength(255)
                .HasColumnName("longitud");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
