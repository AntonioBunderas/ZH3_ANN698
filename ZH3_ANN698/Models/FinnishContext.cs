using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH3_ANN698.Models;

public partial class FinnishContext : DbContext
{
    public FinnishContext()
    {
    }

    public FinnishContext(DbContextOptions<FinnishContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PostalCode> PostalCodes { get; set; }

    public virtual DbSet<Street> Streets { get; set; }

    public virtual DbSet<TelephoneBook> TelephoneBooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ann698.database.windows.net;Initial Catalog=Finnish_phones;User ID=ann698;Password=Password123;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PostalCode>(entity =>
        {
            entity.HasKey(e => e.PostalCodeId).HasName("PK__PostalCo__E197FE61A2CFAA15");

            entity.ToTable("PostalCode");

            entity.Property(e => e.PostalCodeId).HasColumnName("PostalCodeID");
            entity.Property(e => e.Code).HasMaxLength(10);
        });

        modelBuilder.Entity<Street>(entity =>
        {
            entity.HasKey(e => e.StreetId).HasName("PK__Street__6270EB1ADFEA0668");

            entity.ToTable("Street");

            entity.Property(e => e.StreetId).HasColumnName("StreetID");
            entity.Property(e => e.PostalCodeId).HasColumnName("PostalCodeID");
            entity.Property(e => e.StreetName).HasMaxLength(100);

            entity.HasOne(d => d.PostalCode).WithMany(p => p.Streets)
                .HasForeignKey(d => d.PostalCodeId)
                .HasConstraintName("FK__Street__PostalCo__6FE99F9F");
        });

        modelBuilder.Entity<TelephoneBook>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Telephon__AA2FFB8528A6C3B5");

            entity.ToTable("TelephoneBook");

            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PostalCodeId).HasColumnName("PostalCodeID");
            entity.Property(e => e.Region).HasMaxLength(50);
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.PostalCode).WithMany(p => p.TelephoneBooks)
                .HasForeignKey(d => d.PostalCodeId)
                .HasConstraintName("FK__Telephone__Posta__60A75C0F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
