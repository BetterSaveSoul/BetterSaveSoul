using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApp;

public partial class BssContext : DbContext
{
    public BssContext()
    {
    }

    public BssContext(DbContextOptions<BssContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Breed> Breeds { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<GeoLocation> GeoLocations { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Pet> Pets { get; set; }

    public virtual DbSet<PetHealthStatus> PetHealthStatuses { get; set; }

    public virtual DbSet<Species> Species { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Breed>(entity =>
        {
            entity.HasKey(e => new { e.BreedId, e.SpeciesId }).HasName("PK__Breed__3B7A2EFA04D511BF");

            entity.ToTable("Breed");

            entity.Property(e => e.BreedId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BreedID");
            entity.Property(e => e.SpeciesId).HasColumnName("SpeciesID");
            entity.Property(e => e.Aname)
                .HasMaxLength(50)
                .HasColumnName("AName");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Species).WithMany(p => p.Breeds)
                .HasForeignKey(d => d.SpeciesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Breed__SpeciesID__46E78A0C");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("PK__Gender__4E24E8172F21AD07");

            entity.ToTable("Gender");

            entity.Property(e => e.GenderId)
                .ValueGeneratedNever()
                .HasColumnName("GenderID");
            entity.Property(e => e.GenderAname)
                .HasMaxLength(10)
                .HasColumnName("GenderAName");
            entity.Property(e => e.GenderName).HasMaxLength(10);
        });

        modelBuilder.Entity<GeoLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__GeoLocat__E7FEA4772C78FF06");

            entity.ToTable("GeoLocation");

            entity.Property(e => e.LocationId)
                .ValueGeneratedNever()
                .HasColumnName("LocationID");
            entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

            entity.HasOne(d => d.Location).WithOne(p => p.GeoLocation)
                .HasForeignKey<GeoLocation>(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GeoLocati__Locat__47DBAE45");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__Image__7516F4EC2C2BD3EB");

            entity.ToTable("Image");

            entity.Property(e => e.ImageId)
                .ValueGeneratedNever()
                .HasColumnName("ImageID");
            entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Location__E7FEA477957B047B");

            entity.ToTable("Location");

            entity.Property(e => e.LocationId)
                .ValueGeneratedNever()
                .HasColumnName("LocationID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(100);
        });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.PetId).HasName("PK__Pet__48E53802AED9FCE3");

            entity.ToTable("Pet");

            entity.Property(e => e.PetId)
                .ValueGeneratedNever()
                .HasColumnName("PetID");
            entity.Property(e => e.BreedId).HasColumnName("BreedID");
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OwnerProfileId).HasColumnName("OwnerProfileID");
            entity.Property(e => e.Size).HasMaxLength(10);
            entity.Property(e => e.SpeciesId).HasColumnName("SpeciesID");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.Pets)
                .HasForeignKey(d => d.Gender)
                .HasConstraintName("FK__Pet__Gender__49C3F6B7");

            entity.HasOne(d => d.HealthStatusNavigation).WithMany(p => p.Pets)
                .HasForeignKey(d => d.HealthStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pet__HealthStatu__4AB81AF0");

            entity.HasOne(d => d.OwnerProfile).WithMany(p => p.Pets)
                .HasForeignKey(d => d.OwnerProfileId)
                .HasConstraintName("FK__Pet__OwnerProfil__4BAC3F29");

            entity.HasOne(d => d.Species).WithMany(p => p.Pets)
                .HasForeignKey(d => d.SpeciesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pet__SpeciesID__48CFD27E");

            entity.HasOne(d => d.Breed).WithMany(p => p.Pets)
                .HasForeignKey(d => new { d.BreedId, d.SpeciesId })
                .HasConstraintName("FK__Pet__4CA06362");
        });

        modelBuilder.Entity<PetHealthStatus>(entity =>
        {
            entity.HasKey(e => e.PetHealthStatusId).HasName("PK__PetHealt__2A09EBC897C61A57");

            entity.ToTable("PetHealthStatus");

            entity.Property(e => e.PetHealthStatusId)
                .ValueGeneratedNever()
                .HasColumnName("PetHealthStatusID");
            entity.Property(e => e.AhealthStatus)
                .HasMaxLength(255)
                .HasColumnName("AHealthStatus");
            entity.Property(e => e.HealthStatus).HasMaxLength(255);
        });

        modelBuilder.Entity<Species>(entity =>
        {
            entity.HasKey(e => e.SpeciesId).HasName("PK__Species__A938047FB2B58145");

            entity.Property(e => e.SpeciesId)
                .ValueGeneratedNever()
                .HasColumnName("SpeciesID");
            entity.Property(e => e.Aname)
                .HasMaxLength(50)
                .HasColumnName("AName");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserProf__1788CCACC7224134");

            entity.ToTable("UserProfile");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Bio).HasMaxLength(255);
            entity.Property(e => e.DateJoined).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.Location).WithMany(p => p.UserProfiles)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserProfi__Locat__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
