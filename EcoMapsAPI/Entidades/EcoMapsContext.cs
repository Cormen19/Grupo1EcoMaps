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

    public virtual DbSet<CocheElec> CocheElecs { get; set; }

    public virtual DbSet<ContResiduo> ContResiduos { get; set; }

    public virtual DbSet<Eolica> Eolicas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CocheElec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CocheElec");

            entity.Property(e => e.Aparcamiento).HasMaxLength(255);
            entity.Property(e => e.CablesYAdaptadores)
                .HasMaxLength(255)
                .HasColumnName("Cables y adaptadores");
            entity.Property(e => e.F13).HasMaxLength(255);
            entity.Property(e => e.F14).HasMaxLength(255);
            entity.Property(e => e.HayQuePagar)
                .HasMaxLength(255)
                .HasColumnName("Hay que pagar");
            entity.Property(e => e.Horario).HasMaxLength(255);
            entity.Property(e => e.LímiteDeTiempo)
                .HasMaxLength(255)
                .HasColumnName("Límite de tiempo");
            entity.Property(e => e.NúmeroDeConectdores).HasColumnName("Número de conectdores");
            entity.Property(e => e.Reservar).HasMaxLength(255);
            entity.Property(e => e.Situación).HasMaxLength(255);
            entity.Property(e => e.TipoDeConectores)
                .HasMaxLength(255)
                .HasColumnName("Tipo de conectores");
            entity.Property(e => e.Titular).HasMaxLength(255);
        });

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

        modelBuilder.Entity<Eolica>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
