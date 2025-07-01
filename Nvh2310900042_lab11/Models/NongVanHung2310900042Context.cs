using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nvh2310900042_lab11.Models;

public partial class NongVanHung2310900042Context : DbContext
{
    public NongVanHung2310900042Context()
    {
    }

    public NongVanHung2310900042Context(DbContextOptions<NongVanHung2310900042Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NvhEmployee> NvhEmployees { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-IE67TM7\\SQLEXPRESS;Database=NongVanHung_2310900042;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NvhEmployee>(entity =>
        {
            entity.HasKey(e => e.NvhEmpId).HasName("PK__NvhEmplo__0A92E9BFDA6FDC2E");

            entity.Property(e => e.NvhEmpId)
                .ValueGeneratedNever()
                .HasColumnName("nvhEmpId");
            entity.Property(e => e.NvhEmpLevel)
                .HasMaxLength(100)
                .HasColumnName("nvhEmpLevel");
            entity.Property(e => e.NvhEmpName)
                .HasMaxLength(100)
                .HasColumnName("nvhEmpName");
            entity.Property(e => e.NvhEmpStartDate).HasColumnName("nvhEmpStartDate");
            entity.Property(e => e.NvhEmpStatus).HasColumnName("nvhEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
