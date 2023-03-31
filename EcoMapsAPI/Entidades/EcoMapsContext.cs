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

    public virtual DbSet<Bilbogarbi> Bilbogarbis { get; set; }

    public virtual DbSet<CargaElectrica> CargaElectricas { get; set; }

    public virtual DbSet<CocheElec> CocheElecs { get; set; }

    public virtual DbSet<ContResiduo> ContResiduos { get; set; }

    public virtual DbSet<ContenedorBlanco> ContenedorBlancos { get; set; }

    public virtual DbSet<EnvasesLigero> EnvasesLigeros { get; set; }

    public virtual DbSet<Eolica> Eolicas { get; set; }

    public virtual DbSet<PuntosMovile> PuntosMoviles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bilbogarbi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Bilbogarbi");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<CargaElectrica>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("carga_electrica");

            entity.Property(e => e.Cvia)
                .HasMaxLength(255)
                .HasColumnName("CVIA");
            entity.Property(e => e.Dirección)
                .HasMaxLength(255)
                .HasColumnName("DIRECCIÓN");
            entity.Property(e => e.Fid).HasColumnName("FID");
            entity.Property(e => e.Geocodigo)
                .HasMaxLength(255)
                .HasColumnName("GEOCODIGO");
            entity.Property(e => e.Lugar)
                .HasMaxLength(255)
                .HasColumnName("LUGAR");
            entity.Property(e => e.Tipo)
                .HasMaxLength(255)
                .HasColumnName("TIPO");
            entity.Property(e => e.UtmX).HasColumnName("UTM_X");
            entity.Property(e => e.UtmY).HasColumnName("UTM_Y");
        });

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

        modelBuilder.Entity<ContenedorBlanco>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContenedorBlanco");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NºContenedor)
                .HasMaxLength(255)
                .HasColumnName("Nº CONTENEDOR");
        });

        modelBuilder.Entity<EnvasesLigero>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EdukiontziKodeaCodContenedor).HasColumnName("EDUKIONTZI_KODEA/COD_CONTENEDOR");
            entity.Property(e => e.EdukiontziarenModeloaCasModeloContenedorCas)
                .HasMaxLength(255)
                .HasColumnName("EDUKIONTZIAREN MODELOA_CAS/MODELO CONTENEDOR_CAS");
            entity.Property(e => e.EdukiontziarenModeloaEuModeloContenedorEu)
                .HasMaxLength(255)
                .HasColumnName("EDUKIONTZIAREN MODELOA_EU/MODELO CONTENEDOR_EU");
            entity.Property(e => e.EkitaldiaEjercicio).HasColumnName("EKITALDIA/EJERCICIO");
            entity.Property(e => e.HondakinarenFrakzioaCasFraccionDelResiduoCas)
                .HasMaxLength(255)
                .HasColumnName("HONDAKINAREN FRAKZIOA_CAS/FRACCION DEL RESIDUO_CAS");
            entity.Property(e => e.HondakinarenFrakzioaEuFraccionDelResiduoEu)
                .HasMaxLength(255)
                .HasColumnName("HONDAKINAREN FRAKZIOA_EU/FRACCION DEL RESIDUO_EU");
            entity.Property(e => e.Id).HasColumnName("_id");
            entity.Property(e => e.Latitude)
                .HasMaxLength(255)
                .HasColumnName("latitude");
            entity.Property(e => e.LatitudeGeo)
                .HasMaxLength(255)
                .HasColumnName("latitude GEO");
            entity.Property(e => e.Longitude)
                .HasMaxLength(255)
                .HasColumnName("longitude");
            entity.Property(e => e.LongitudeGeo)
                .HasMaxLength(255)
                .HasColumnName("longitude GEO");
            entity.Property(e => e.UdalerriaKodeaCodMunicipio).HasColumnName("UDALERRIA_KODEA/COD_MUNICIPIO");
            entity.Property(e => e.UdalerriaMunicipio)
                .HasMaxLength(255)
                .HasColumnName("UDALERRIA/MUNICIPIO");
        });

        modelBuilder.Entity<Eolica>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<PuntosMovile>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Desde).HasColumnType("datetime");
            entity.Property(e => e.Hasta).HasColumnType("datetime");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lon).HasColumnName("lon");
            entity.Property(e => e.Ubicacion).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
